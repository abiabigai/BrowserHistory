# Simulador de historial de navegación web (Pilas)

Tarea 3.3 – Estructuras lineales. Aplicación **Windows Forms (.NET 10, C#)** que
simula los botones Atrás / Adelante de un navegador usando dos pilas
implementadas con nodos enlazados.

## Requisitos
- Windows 10/11
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code con las extensiones **C#** y **C# Dev Kit**

## Ejecutar (desde la terminal de VS Code)
```bash
dotnet run --project BrowserHistory.App
```

## Pruebas
```bash
dotnet test
```

## Estructura
```
BrowserHistory.slnx
BrowserHistory.Core/    Node, LinkedStack<T>, EmptyStackException, History
BrowserHistory.App/     Interfaz Windows Forms (MainForm)
BrowserHistory.Tests/   Pruebas unitarias xUnit
REPORTE.md              Reporte de la práctica
```
