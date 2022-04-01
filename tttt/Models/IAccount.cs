using System;
using System.Collections.Generic;
using System.Text;

namespace tttt.Models
{
    interface IAccount
    {
        public bool PasswordChecker(string pass);
        public void ShowInfo();
    }
}
