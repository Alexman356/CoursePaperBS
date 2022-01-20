using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CoursePaper
{
    static class Program
    {
        [STAThread]
        private static void Main()
        {
            TerminateServer();
            StartServer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ApplicationExit += AppOrProcessExited;

            Application.Run(new AutorizationForm());
        }

        private static void AppOrProcessExited(object sender, EventArgs e)
        {
            TerminateServer();
        }

        static void StartServer()
        {
            string serverPath = $"{Directory.GetCurrentDirectory()}\\OpenServer\\Open Server.exe";

            try
            {
                Process.Start(serverPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при запуске сервера базы данных: {ex}", "Ошибка!");
            }
        }

        private static void TerminateServer()
        {
            try
            {
                foreach (var process in Process.GetProcesses())
                {
                    if (process.ProcessName == "Open Server")
                    {
                        process.Kill();
                    }
                }

                Thread.Sleep(1000);

                foreach (var process in Process.GetProcesses())
                {
                    if ((process.ProcessName == "httpd") ||
                        (process.ProcessName == "mysqld"))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при остановки server!" + ex, "Ошибка!");
            }
        }
    }
}