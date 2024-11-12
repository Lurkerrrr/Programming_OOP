using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class A
    {
        public virtual void Virtual()
        {
            Console.WriteLine("Metoda wirtualna w A");
        }

        public void NotVirtual()
        {
            Console.WriteLine("Metoda nie wirtualna w A");
        }

    }

}  

