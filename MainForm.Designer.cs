namespace BrowserHistory.App;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;

    private Button btnBack = null!;
    private Button btnForward = null!;
    private TextBox txtUrl = null!;
    private Button btnVisit = null!;
    private Label lblCurrentTitle = null!;
    private Label lblCurrentPage = null!;
    private Label lblBackTitle = null!;
    private ListBox lstBack = null!;
    private Label lblForwardTitle = null!;
    private ListBox lstForward = null!;
    private Label lblStatus = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        btnBack = new Button();
        btnForward = new Button();
        txtUrl = new TextBox();
        btnVisit = new Button();
        lblCurrentTitle = new Label();
        lblCurrentPage = new Label();
        lblBackTitle = new Label();
        lstBack = new ListBox();
        lblForwardTitle = new Label();
        lstForward = new ListBox();
        lblStatus = new Label();
        SuspendLayout();

        // btnBack
        btnBack.Location = new Point(12, 12);
        btnBack.Size = new Size(80, 30);
        btnBack.Text = "← Atrás";
        btnBack.Click += btnBack_Click;

        // btnForward
        btnForward.Location = new Point(98, 12);
        btnForward.Size = new Size(90, 30);
        btnForward.Text = "Adelante →";
        btnForward.Click += btnForward_Click;

        // txtUrl
        txtUrl.Location = new Point(196, 15);
        txtUrl.Size = new Size(360, 23);
        txtUrl.PlaceholderText = "Escribe una dirección, ej. www.google.com";
        txtUrl.KeyDown += txtUrl_KeyDown;

        // btnVisit
        btnVisit.Location = new Point(564, 12);
        btnVisit.Size = new Size(90, 30);
        btnVisit.Text = "Visitar";
        btnVisit.Click += btnVisit_Click;

        // lblCurrentTitle
        lblCurrentTitle.AutoSize = true;
        lblCurrentTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblCurrentTitle.Location = new Point(12, 60);
        lblCurrentTitle.Text = "Página actual:";

        // lblCurrentPage
        lblCurrentPage.BorderStyle = BorderStyle.FixedSingle;
        lblCurrentPage.Font = new Font("Segoe UI", 14F);
        lblCurrentPage.Location = new Point(12, 82);
        lblCurrentPage.Size = new Size(642, 60);
        lblCurrentPage.TextAlign = ContentAlignment.MiddleCenter;
        lblCurrentPage.Text = "(sin página)";

        // lblBackTitle
        lblBackTitle.AutoSize = true;
        lblBackTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblBackTitle.Location = new Point(12, 158);
        lblBackTitle.Text = "Pila ATRÁS (tope arriba):";

        // lstBack
        lstBack.Location = new Point(12, 180);
        lstBack.Size = new Size(310, 180);

        // lblForwardTitle
        lblForwardTitle.AutoSize = true;
        lblForwardTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblForwardTitle.Location = new Point(344, 158);
        lblForwardTitle.Text = "Pila ADELANTE (tope arriba):";

        // lstForward
        lstForward.Location = new Point(344, 180);
        lstForward.Size = new Size(310, 180);

        // lblStatus
        lblStatus.AutoSize = true;
        lblStatus.ForeColor = Color.DimGray;
        lblStatus.Location = new Point(12, 375);
        lblStatus.Text = "Listo.";

        // MainForm
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(666, 405);
        Controls.Add(btnBack);
        Controls.Add(btnForward);
        Controls.Add(txtUrl);
        Controls.Add(btnVisit);
        Controls.Add(lblCurrentTitle);
        Controls.Add(lblCurrentPage);
        Controls.Add(lblBackTitle);
        Controls.Add(lstBack);
        Controls.Add(lblForwardTitle);
        Controls.Add(lstForward);
        Controls.Add(lblStatus);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Simulador de historial de navegación (Pilas)";
        ResumeLayout(false);
        PerformLayout();
    }
}
