using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CEO : IManager
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public decimal Salary { get ; set ; }

        public void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }



        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired!");
        }
    }
}
