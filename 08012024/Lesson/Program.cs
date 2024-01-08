using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reverse("");

            int[] nums = new int[4];
            string[] names = new string[4];

            var num1 = nums[0];
            var name1 = names[0];

            int? age = 10;
            age = null;


            DateTime date1 = new DateTime(2020,10,20,14,05,10);
            Console.WriteLine(date1);
            Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date1.ToString("dd.MM.yyyy"));
            Console.WriteLine(date1.ToString("dddd dd MMMM yyyy "));

            Console.WriteLine(date1);
            Console.WriteLine(date1.Date);
            Console.WriteLine(date1.Year);
            Console.WriteLine(date1.Month);
            Console.WriteLine(date1.DayOfWeek);
            Console.WriteLine(date1.Minute);
            Console.WriteLine(date1.DayOfYear);
            Console.WriteLine(date1.Day);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);

            DateTime date2 = new DateTime(2020, 10, 21, 15, 30, 10);


            Console.WriteLine(date1>date2);


            var diff = date2-date1;

            Console.WriteLine(diff.TotalDays);
            Console.WriteLine(diff.TotalHours);
            Console.WriteLine(diff.TotalMinutes);
            Console.WriteLine(diff.TotalSeconds);
            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.Minutes);

            string examDateStr;
            DateTime examDate;
            do
            {
                Console.WriteLine("Imtahan tarixini daxil et:");
                examDateStr = Console.ReadLine();

            } while (!DateTime.TryParse(examDateStr,out examDate));
          

            var untilDays = (examDate.Date - DateTime.Now.Date).TotalDays;

            Console.WriteLine(untilDays);

            string priceStr;
            int price;

            do
            {
                Console.WriteLine("Price: ");
                priceStr = Console.ReadLine();

            } while (!int.TryParse(priceStr,out price));

            Console.WriteLine(price);
        }

        static bool TryConvert(string str,out int num)
        {
            try
            {
                num = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        }


        static string Reverse(string str)
        {
            //string newStr = "";
            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    newStr+= str[i];
            //}

            //return newStr;


            //if (str == null || str == "" || str.Trim().Length==0) return str;
            //if (String.IsNullOrEmpty(str)) return str;
            if (String.IsNullOrWhiteSpace(str)) return str;


            StringBuilder strBuilder = new StringBuilder();

            for (int i = str.Length-1; i>=0; i--)
            {
                strBuilder.Append(str[i]);
            }

            return strBuilder.ToString();
        }

        static string MakeFullname(string name,string? surname=null)
        {
            return name + " " + surname;
        }
    }
}
