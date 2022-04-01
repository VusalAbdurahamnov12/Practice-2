using System;
using System.Collections.Generic;
using System.Text;
using tttt.Exceptions;

namespace tttt.Models
{
    public class Group
    {
        private static int _studentLimit;
        private string _GroupNo;
        private static bool _upper1 =false;


        public static int StudentLimit { get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18) _studentLimit = value;
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
        private static Student[] student = new Student[0];
        public static bool CheckGroupNo(string groupNo)
        {
            int _digit1 = 0;
            if (!String.IsNullOrEmpty(groupNo) && !String.IsNullOrWhiteSpace(groupNo) && groupNo.Length >= 5)
            {
                int j = 1; //1 ci index
                char[] charArr = groupNo.ToCharArray();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (Char.IsUpper(charArr[i]) && Char.IsUpper(charArr[j]))  _upper1 = true;
                    else if (Char.IsDigit(charArr[i]))  _digit1++;
                    if (_upper1 == true&& _digit1==3) return true;
                }
            }
            throw new NotAvaiavleException("Grup nomresi sehvdir");

        }
        public static void AddStudent(Student stu)
        {
                Array.Resize(ref student, student.Length + 1);
                student[student.Length -1] = stu;
        }
        public Group(string groupNo,int studentLimit)
        {
            GroupNo=groupNo;
            StudentLimit=studentLimit;
        }
        public static void GetAllStudents() 
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"ID-{student[i].Id}\nFullname-{student[i].Fullname}\nPoint-{student[i].Point}");
            }
        }
        public static bool CheckGroupLimit(int studentLimit)
        {
            if (studentLimit >= 5 && studentLimit <= 18)
                return true;
            throw new NotAvaiavleException("qrup 5-18 araliqda ol biler ");
        }
        public static Student[] studenst()
        {
             return student;
        }
        public static void StudenIdInfo(int id)
        {
            for (int i = 0; i < student.Length; i++)
            {
                if (id==i)
                {
                    Console.WriteLine($"ID-{student[i].Id}\nFullname-{student[i].Fullname}\nPoint-{student[i].Point}");
                }
            }
        }

    }
}
