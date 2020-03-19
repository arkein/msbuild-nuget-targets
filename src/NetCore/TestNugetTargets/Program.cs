using MeReference1;
using MeReference2;
using System;

namespace TestNugetTargets
{
    class Program
    {
        static void Main(string[] args)
        {
            var clas2 = new Class2(new Class1());
            Console.WriteLine("Hello World!");
        }
    }
}
