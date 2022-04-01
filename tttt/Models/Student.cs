using System;
using System.Collections.Generic;
using System.Text;
using tttt.Exceptions;

namespace tttt.Models
{
    public class Student
    {
        private static int _id;
        public int Id { get; }
        private string _Fullname;
        private double _Point;
        public string Fullname
        {
            get { return _Fullname; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _Fullname = value;
            }
        }
        public double Point
        {
            get { return _Point; }
            set
            {
                if (value >= 100) _Point = value;
            }
        }
        static Student()
        {
            _id = 0;
        }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public Student(string fullname, double point) :this()
        {
            Fullname = fullname;
            Point = point;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id-{Id}\nFullname-{Fullname}\nPoint-{Point}");
        }

    }
}
