using WinForms_with_MSAccess.Forms;

namespace WinForms_with_MSAccess;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Dashboard());
    }
}
