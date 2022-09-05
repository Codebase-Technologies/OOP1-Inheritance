using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int theGreaterNumEver = Int32.MaxValue;
            GeneratorPro PelumGenPro = new GeneratorPro();
            PelumGenPro.GenLabel = "PelumiPower!";
        }

    }

    internal class GeneratorPro
    {
        private string GenLabel { get; set; }

        private int serialNoId;

        void Ignition(int petrolQuan)
        {
            Console.WriteLine($"{GenLabel} has started working");
        }
    }
}
