using MeReference;
using MeReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNugetTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2(class1);
            Console.WriteLine("Don't read me, read the verbose build log");
        }
    }
}
