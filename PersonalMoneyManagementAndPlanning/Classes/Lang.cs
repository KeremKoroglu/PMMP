using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMoneyManagementAndPlanning.Classes
{
    public class Lang
    {
        public static string AppLang;

        private static readonly ResourceManager RM = new("PersonalMoneyManagementAndPlanning.Resources.LangResources", Assembly.GetExecutingAssembly());

        public static void SetLang(string lang)
        {
            AppLang = lang;
        }

        public static string GetLang()
        {
            return AppLang;
        }

        public static string GetText(string text) 
        {
            return RM.GetString(text + AppLang);
        }

        public static string[] GetMonths() 
        {
            return new string[] {GetText("January"), GetText("February"), GetText("March"), GetText("April"), GetText("May"), GetText("June"), GetText("July"), GetText("August"), GetText("September"), GetText("October"), GetText("November"), GetText("December")};
        }
    }
}
