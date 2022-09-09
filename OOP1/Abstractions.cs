using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal abstract class Animal
    {
        public int Legs { get; set; }

    }

    class Normal
    {
        void DoNormal(){
            Animal pet = new Animal();
        }
    }


   public abstract class VehicleUsage
    {
        public int Tyres { get; set; }

        void ChangeTyres(int tyres)
        {
            Console.WriteLine("Change the faulty tyres");
        }

        public abstract void RepairExhaust();
        
        double Driving(decimal petrolQuantity)
        {
            return 50;
        }
    }

   class MechanicUsage : VehicleUsage
   {
       public override void RepairExhaust()
       {
           Console.WriteLine("I will check and fix from the manifold");
       }

    }
}
