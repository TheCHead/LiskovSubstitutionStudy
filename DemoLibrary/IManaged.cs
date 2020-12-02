using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    interface IManaged : IEmployee
    {
        IEmployee ManagedBy { get; set; }

        void AssignManager(IEmployee manager);
    }
}
