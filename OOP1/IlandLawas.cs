using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP1
{

    internal interface INigeriaBuildingLaws
    {
        public int FireExtinguishers { get; set; }

       public int MakeEmergencyExits(double[] area);

    }
    internal interface IlagosBuildingLaws : INigeriaBuildingLaws
    {
        public string CofO { get; set; }

        void MakeCarPark(double area);

        void StrongFoundation(int cement, int rods);

    }

    class Mansion : IlagosBuildingLaws
    {
        public string CofO { get; set; }
        public int FireExtinguishers { get; set; }

        public void MakeCarPark(double area)
        {
            area = 50.67d;
            Console.WriteLine($"I have build my car park of {area}sq meters");
        }

        public void StrongFoundation(int cement, int rods)
        {

            Console.WriteLine($"I have build my foundation with  {cement} cements and {rods} iron bars");
        }

       public int MakeEmergencyExits(double[] area)
        {
            throw new NotImplementedException();
        }

        void MakeGarden()
        {
            Console.WriteLine("Call gardening andparks person");
        }
    }

    class TerraceBungalow :IlagosBuildingLaws
    {
        public string CofO { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MakeCarPark(double area)
        {
            area = 34.67d;
            Console.WriteLine($"I have build my car park of {area}sq meters");
        }

        public void StrongFoundation(int cement, int rods)
        {
            throw new NotImplementedException();
        }

        double MakeSwimmingPool(int money)
        {
            return 20.7d;
        }
    }
}