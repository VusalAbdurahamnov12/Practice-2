using System;
using tttt.Models;
namespace tttt
{
    class Program
    {
        static void Main(string[] args)
        {
            string Fullname = "";
            int  expression =0;

            do
            {
               Input:
                try 
                {
                    Console.WriteLine("Secim edin");
                    expression = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Dogru daxil edin");
                    goto Input;
                }
                switch (expression)
                {
                    //case 1:
                    //    mail=MailInput( mail);
                    //    Fullname = FullNameInput(Fullname);

                    //    break;
                    case 2:
                        // code block
                        break;
                    default:
                        // code block
                        break;
                }
            } while (expression!=3);
        }
        public static string MailInput(out string mail)
        {
            Mail:
            Console.WriteLine("Mail daxil edin");
            mail = Console.ReadLine();
            if (!String.IsNullOrEmpty(mail))
            {
                Console.WriteLine("Bosluq olmaz.");
                goto Mail;
            }
            return mail;
        }
        public static string FullNameInput(string Fullname)
        {
        FullName:
            Console.WriteLine("Ad daxil edin");
            Fullname = Console.ReadLine();
            if (!String.IsNullOrEmpty(Fullname))
            {
                Console.WriteLine("Bosluq olmaz.");
                goto FullName;
            }
            return Fullname;
        }
        public static void PassInput(string pass)
        {
            Console.WriteLine("Parolu daxil edin");
            pass = Console.ReadLine();
        }
    }
}
