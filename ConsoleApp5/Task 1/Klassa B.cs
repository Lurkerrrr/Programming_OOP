using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class B : A
    { 
        public override void Virtual()
        {
            Console.WriteLine("Metoda wirtualna w B");
        }
    }
}
