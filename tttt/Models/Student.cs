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
        private int _Point;
        public string Fullname
        {
            get { return _Fullname; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) _Fullname = value;
                else throw new NotAvaiavleException("Bosluq daxil etmeyin!!");
            }
        }
        public int Point
        {
            get { return _Point; }
            set
            {
                if (value >= 100) _Point = value;
                else throw new NotAvaiavleException("100");
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
        public Student(string fullname,int point) :this()
        {
            Fullname = fullname;
            Point = point;
        }

    }
}
