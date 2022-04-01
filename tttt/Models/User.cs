using System;
using System.Collections.Generic;
using System.Text;

namespace tttt.Models
{
    public class User : IAccount
    {
        private static int _id;
        private  string _Fullname;
        private  string _Email;
        private  string _Password;
        public string Fullname {
            get { return _Fullname; }
            set 
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value)) _Fullname = value;
            } 
        }
        private int Id { get; }
        public string Email
        {
            get { return _Email; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _Email = value;
            }
        }
        public string Password
        {
            get { return _Password; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _Password = value;
            }
        }
        private bool _PassLength=false;
        private bool _upper = false;
        private bool _lower = false;
        private bool _digit = false;
        public bool PasswordChecker(string pass)
        {
            
            CheckPasswordLength(pass);
            if (_PassLength == true)
            {
                char[] charArr = pass.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (Char.IsUpper(charArr[i]))return _upper = true;
                    else if (Char.IsLower(charArr[i])) return _lower = true;
                    else if (Char.IsDigit(charArr[i])) return _digit = true;
                    if (_upper == true && _lower == true && _digit == true) break;
                }
            }
            return false;
        }
        public bool CheckPasswordLength(string pass)
        {
            if (pass.Length > 8 && !String.IsNullOrEmpty(pass)) return _PassLength=true;
            else return _PassLength;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User id {Id}\nFullname {Fullname}\nemail {Email}");
        }
        public User()
        {
            _id++;
            Id = _id;
        }
        public User(string email,string pass):this()
        {
            Email = email;
            Password = pass;
            PasswordChecker(pass);
        }
        public User(string email, string pass,string fullname) : this()
        {
            Email = email;
            Password = pass;
            Fullname = fullname;
        }
    }
}
