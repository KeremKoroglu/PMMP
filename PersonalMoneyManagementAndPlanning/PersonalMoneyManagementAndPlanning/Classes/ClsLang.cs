using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMoneyManagementAndPlanning.Classes
{
    public class ClsLang
    {
        public static string Lang;

        private static readonly ResourceManager RM = new("PersonalMoneyManagementAndPlanning.Resources.LangResources", Assembly.GetExecutingAssembly());

        public static void SetLang(string lang)
        {
            Lang = lang;
        }

        public static string GetLang()
        {
            return Lang;
        }

        public static string GetText(string text) 
        {
            return RM.GetString(text + Lang);
        }

        public static string[] GetMonths() 
        {
            return new string[] {GetText("January"), GetText("February"), GetText("March"), GetText("April"), GetText("May"), GetText("June"), GetText("July"), GetText("August"), GetText("September"), GetText("October"), GetText("November"), GetText("December")};
        }
    }
}
