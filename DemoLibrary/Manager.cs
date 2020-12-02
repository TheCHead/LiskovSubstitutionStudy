using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Manager : IManager, IManaged
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public decimal Salary { get ; set ; }
        public IEmployee ManagedBy { get ; set ; }

        public void AssignManager(IEmployee manager)
        {
            ManagedBy = manager;
        }

        public void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
