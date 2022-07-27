using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
   abstract class myclass
    {
        abstract public void x();
        abstract public int REQEM { get; set; }
    }

    class numune : myclass
    {
        public override int REQEM { get ; set ; }

        public override void x()
        {
            Console.WriteLine("salam");
        }
    }
}
