using System;
using System.Collections.Generic;
using System.Text;
using tttt.Exceptions;

namespace tttt.Models
{
    class Group
    {
        private int _studentLimit;
        private string _GroupNo;
        private bool _upper1 =false;
        private bool _digit1 =false;
        private bool _digit2 =false;
        private bool _digit3 =false;

        public int StudentLimit { get { return _studentLimit; }
            set
            {
                if (value > 5 || value < 18) _studentLimit = value;
                else throw new NotAvaiavleException("Limiti kecdiniz!");
            } 
        }
        public string GroupNo {
            get { return _GroupNo; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value) && value.Length >=5) _GroupNo = value;
                else throw new NotAvaiavleException("Limiti kecdiniz!");
            }
        }
        private Student[] student = new Student[0];
        public bool CheckGroupNo(string groupNo)
        {
            if (!String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo) && groupNo.Length >= 5)
            {
                int j = 1; //1 ci index
                char[] charArr = groupNo.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (Char.IsUpper(charArr[i]) && Char.IsUpper(charArr[j])) return _upper1 = true;
                    else if (Char.IsDigit(charArr[i])) return _digit1 = true;
                    else if (Char.IsDigit(charArr[i])) return _digit2 = true;
                    else if (Char.IsDigit(charArr[i])) return _digit3 = true;
                    if (_upper1 == true && _digit1 == true && _digit2 == true && _digit3 == true) return true; break;
                }
            }return false; throw new NotAvaiavleException("Grup nomresi sehvdir");

        }
        public void AddStudent(Student stu)
        {
            if (StudentLimit > student.Length)
            {
                Array.Resize(ref student, student.Length + 1);
                student[student.Length + 1] = stu;
            }
            else throw new NotAvaiavleException("Limit kecildi");
        }
        public Group(string groupNo,int studentLimit)
        {
            GroupNo=groupNo;
            StudentLimit=studentLimit;
        }
        public void GetAllStudents() 
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"ID-{student[i].Id}\nFullname-{student[i].Fullname}\nPoint-{student[i].Point}");
            }
        }
    }
}
