using PersonalMoneyManagementAndPlanning.MainForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PersonalMoneyManagementAndPlanning.Classes;

namespace PersonalMoneyManagementAndPlanning
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string stateFilePath = "state.txt";
            string identityFilePath = "identity.txt";
            string langFilePath = "lang.txt";

            Lang.AppLang = File.ReadAllText(langFilePath);

            if (File.Exists(stateFilePath))
            {
                string content = File.ReadAllText(stateFilePath);

                if (content == "1")
                {
                    if (File.Exists(identityFilePath))
                    {
                        Database.SetId(File.ReadAllText(identityFilePath));
                    }

                    Application.Run(new FrmMain());
                }
                else
                {
                    Application.Run(new FrmLogin());
                }
            }
            else
            {
                Application.Run(new FrmLogin());
            }
        }
    }
}
