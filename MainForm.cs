using BrowserHistory.Core;

namespace BrowserHistory.App;

public partial class MainForm : Form
{
    private readonly History _history = new();

    public MainForm()
    {
        InitializeComponent();
        RefreshView();
    }

    private void btnVisit_Click(object? sender, EventArgs e) => VisitPage();

    private void txtUrl_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            VisitPage();
        }
    }

    private void btnBack_Click(object? sender, EventArgs e)
    {
        string? page = _history.GoBack();
        RefreshView(page is null ? "No hay páginas anteriores." : $"Retrocediste a: {page}");
    }

    private void btnForward_Click(object? sender, EventArgs e)
    {
        string? page = _history.GoForward();
        RefreshView(page is null ? "No hay páginas siguientes." : $"Avanzaste a: {page}");
    }

    private void VisitPage()
    {
        try
        {
            string page = _history.Visit(txtUrl.Text);
            txtUrl.Clear();
            RefreshView($"Visitando: {page}");
        }
        catch (ArgumentException)
        {
            MessageBox.Show("La dirección no puede estar vacía.", "Dato requerido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void RefreshView(string status = "Listo.")
    {
        lblCurrentPage.Text = _history.Current ?? "(sin página)";

        lstBack.Items.Clear();
        foreach (string page in _history.BackPages)
            lstBack.Items.Add(page);

        lstForward.Items.Clear();
        foreach (string page in _history.ForwardPages)
            lstForward.Items.Add(page);

        btnBack.Enabled = _history.CanGoBack;
        btnForward.Enabled = _history.CanGoForward;
        lblStatus.Text = status;
    }
}
