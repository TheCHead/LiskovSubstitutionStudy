using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee ManagedBy { get; set; }


        public void AssignManager(IEmployee manager)
        {
            ManagedBy = manager;
        }


    }
}
