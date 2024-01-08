using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasDigit("sa1lam"));

            string str = "salam necesen Davud?";
            Console.WriteLine(FindLastWord(str));

        }

        //Verilmis yazida reqem olub olmadigini tapan metod
        static bool HasDigit(string str) 
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i])) return true;
            }

            return false;
        }

        //Verilmis yazinin icindeki ilk sozu qaytaran metod
        static string FindFirstWord(string str)
        {
            str = str.Trim();
            int startIndex = 0;
            int endIndex = str.IndexOf(' ');

            var result = str.Substring(startIndex, (endIndex - startIndex));
            return result;
        }

        static string FindLastWord(string str)
        {
            //str= str.Trim();

            //int startIndex = str.LastIndexOf(' ')+1;
            //int endIndex = str.Length;

            ////var result = str.Substring(startIndex, (endIndex - startIndex));
            //var result = str.Substring(startIndex);


            //return result;

            return str.Substring(str.LastIndexOf(' '));
        }
    }
}
