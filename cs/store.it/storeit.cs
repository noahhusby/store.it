using store.it.ux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store.it
{
    static class storeit
    {
        public static Instance instance;
        public static storeitform stf;
        public static Login login;
        private static void InitSub()
        {
            instance = new Instance();
            stf = new storeitform();
            login = new Login();
        }
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            InitSub();
            Application.EnableVisualStyles();
            Application.Run(login);
        }
        public static void setWindow(UserControl window)
        {
            window.Dock = DockStyle.Fill;
            stf.Controls.Clear();
            stf.Controls.Add(window);
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
