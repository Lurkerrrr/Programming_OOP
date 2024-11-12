using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class C : B
    {
        public override void Virtual()
        {
            Console.WriteLine("Metoda virtualna w C");
        }

        public void methodCall()
        { 
            base.Virtual(); //wywołanie metody
        }
    }
}
