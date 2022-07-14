using WordProcessor.Core.Presenters;

namespace WordProcessor.WinForms;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var view = new MainForm();
        var presenter = new MainFormPresenter(view);
        Application.Run(view);
    }
}