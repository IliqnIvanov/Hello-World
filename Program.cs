using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToDateTime("12/02/21 10:56:09").ToString("MMM.dd,yyyy HH:mm:ss");


            DateTime bDay = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year - bDay.Year;

            if (today < bDay.AddYears(age)) 
            {
                age--;
            }
            Console.WriteLine(age);
            Console.WriteLine(age + 10);

           
        }
    }
}
