using System;
using tttt.Exceptions;
using tttt.Models;
namespace tttt
{
    public class Program
    {
        static void Main(string[] args)
        {
            int  expression =0;
            FullNameInput(out string fullname);
            MailInput(out string email);
            PassInput(out string  pass);
            User user1 = new User(email, pass, fullname);
            do
            {
               Input:
                try 
                {
                    Console.WriteLine("[0]-Exit\n[1]-ShowInfo\n[2]-Create new group");
                    expression = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Dogru daxil edin:");
                    goto Input;
                }
                switch (expression)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        user1.ShowInfo();
                        Console.WriteLine("-------------------");
                        break;
                    case 2:
                        Console.Clear();
                        GroupNoInput(out string groupNo);
                        SetStudentLimit(out int StudentLimit);
                        Group group = new Group(groupNo, StudentLimit);
                        Console.Clear();
                        Console.WriteLine("Grup yaradildi");
                        // code block
                        break;
                    default:
                        // code block
                        break;
                }
            } while (expression!=0);
            do
            {
                Console.WriteLine($"[0]-Quit\n[1]-Show all students\n[2]- Get student by id\n[3]-Add student");
                expression=Convert.ToInt32(Console.ReadLine());
                switch (expression)
                {
                    case 1:
                        Console.Clear();
                        StuInfos();
                        break;
                    case 2:
                        Console.Clear();
                        StudenID(out int id);
                        Group.StudenIdInfo(id);
                        break;
                    case 3:

                        Group:
                        Console.Clear();
                        try 
                        {
                            FullNameInput(out fullname);
                            StudentPoint(out double point);
                            Student st = new Student(fullname, point);
                            Group.AddStudent(st);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message);goto Group; }
                        
                        break;
                    default:
                        break;
                }
            } while (expression!=0);

        }
        //mail
        static void MailInput(out string mail)
        {
            Mail:
            try
            {
                Console.WriteLine("Mail daxil edin");
                mail = Console.ReadLine();
                if (String.IsNullOrEmpty(mail) || string.IsNullOrWhiteSpace(mail))
                {
                    Console.WriteLine("Bosluq olmaz.");
                    goto Mail;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Mail;
            }

        }
        //Fullname
        static void FullNameInput(out string Fullname)
        {
        FullName:
            try 
            {
                Console.WriteLine("Ad daxil edin");
                Fullname = Console.ReadLine();
                if (String.IsNullOrEmpty(Fullname) || string.IsNullOrWhiteSpace(Fullname))
                {
                    Console.WriteLine("Bosluq olmaz.");
                    goto FullName;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto FullName;
            }

        }
        //pass
        public static void PassInput(out string pass)
        {
         Pass:
            try 
            {
                Console.WriteLine("Parolu daxil edin");
                pass = Console.ReadLine();
                User.PasswordChecker(pass);
                if (String.IsNullOrEmpty(pass) || string.IsNullOrWhiteSpace(pass))
                {
                    Console.WriteLine("Bosluq olmaz.");
                    goto Pass;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Pass;
            }

        }
        //groupno
        static void GroupNoInput(out string groupNo)
        {
        GroupNoInput:
            try
            {
                Console.Write("Qrup nomresini daxiledin: ");
                groupNo = Console.ReadLine();
                Group.CheckGroupNo(groupNo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto GroupNoInput;
            }
        }
        //StudentLimit
        static void SetStudentLimit(out int StudentLimit)
        {
        SetStudentLimit:
            try
            {
                Console.Write("Sagird sayini daxil edin: ");
                StudentLimit = Convert.ToInt32(Console.ReadLine());
                Group.CheckGroupLimit(StudentLimit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto SetStudentLimit;
            }
        }
        //sStudenInfo
        static void  StuInfos()
        {
            foreach (var item in Group.)//edit!
            {
                Console.WriteLine($"ID-{item.Id}\nFulla Name{item.Fullname}\nPoint{item.Point}");
            }

        }
        //Find id  student
        static void StudenID(out int id)
        {
        StudenID:
            try
            {
                Console.Write("ID daxil edin: ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto StudenID;
            }
        }
        //Student point
        static void StudentPoint(out double point)
        {
        SetStudentPoint:
            try
            {
                Console.Write("Bali daxil edin : ");
                point = Convert.ToInt32(Console.ReadLine());
                if (point<= 0 || point >= 100)
                    throw new NotAvaiavleException("Bal 0-100 arasi ola biler ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto SetStudentPoint;
            }
        }
    }
}
