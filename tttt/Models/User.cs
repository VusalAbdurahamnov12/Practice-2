using System;
using System.Collections.Generic;
using System.Text;
using tttt.Exceptions;

namespace tttt.Models
{
    public class User : IAccount
    {
        private static int _id;
        private static string _Fullname;
        private static string _Email;
        private static string _Password;
        public static string Fullname {
            get { return _Fullname; }
            set 
            {
                if (string.IsNullOrEmpty(value)||string.IsNullOrWhiteSpace(value)) _Fullname = value;
            } 
        }
        public  int Id { get; }
        public static string Email
        {
            get { return _Email; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _Email = value;
            }
        }
        public static string Password
        {
            get { return _Password; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _Password = value;
            }
        }
        private static bool _PassLength=false;
        private static bool _upper = false;
        private static bool _lower = false;
        private static bool _digit = false;
        public static bool PasswordChecker(string pass)
        {
            
            CheckPasswordLength(pass);
            if (_PassLength == true)
            {
                char[] charArr = pass.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (Char.IsUpper(charArr[i])) _upper = true;
                    else if (Char.IsLower(charArr[i]))  _lower = true;
                    else if (Char.IsDigit(charArr[i]))  _digit = true;
                    if (_upper == true && _lower == true && _digit == true) return true  ;
                }
            }
            throw new NotAvaiavleException("Dogru daxil edin");

        }
        public static bool CheckPasswordLength(string pass)
        {
            if (pass.Length > 8 && !String.IsNullOrEmpty(pass)) return _PassLength=true;
            else return _PassLength;
        }

        public  void ShowInfo()
        {
            Console.WriteLine($"User id {Id}\nFullname {_Fullname}\nemail {_Email}");
        }
        static User()
        {
            _id = 0;
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
            _Password = email;
            _Email = pass;
            _Fullname = fullname;
        }
    }
}
