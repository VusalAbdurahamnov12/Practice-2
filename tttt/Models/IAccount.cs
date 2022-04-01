using System;
using System.Collections.Generic;
using System.Text;

namespace tttt.Models
{
    interface IAccount
    {
        public static bool PasswordChecker(string pass) { return true; }
        public static void ShowInfo() { }
    }
}
