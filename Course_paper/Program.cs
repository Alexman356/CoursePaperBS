using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_paper
{
    static class Program
    {
        static readonly string server_path = $"{Directory.GetCurrentDirectory()}\\OpenServer\\Open Server.exe";
        [STAThread]
        static void Main()
        {
            StartServer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AutorizationForm());
        }
        static void StartServer()
        {
            try
            {
                Process.Start(server_path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске сервера базы данных: {ex}", "Ошибка!");
            }
        }
    }
}
