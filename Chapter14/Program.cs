using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {

            var pets = new List<IVirtualPet>();

           
            pets.Add  (new FoodiePet("エイミー"));        
            pets.Add (new CheerfulPet("クー"));
            pets.Add (new SleepyPet("ライアン"));

            foreach(var pet in pets)
            {
                pet.Eat();
                pet.Play();
                pet.Sleep();

                Console.WriteLine($"{pet.Name}機嫌:{pet.Mood} エネルギー:{pet.Energy}");

            }
        }
    }
}
