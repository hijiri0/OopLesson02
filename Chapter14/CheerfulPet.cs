using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public CheerfulPet(string name) 
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public  void Eat()
        {
            Mood += 0;  // 値は変化しない
            Energy += 5;
            Console.WriteLine("CheerfulPet.Eatメソッドが実行されました");
        }

        public  void Play()
        {
            Mood += 3;
            Energy -= 10;
            Console.WriteLine("CheerfulPet.Playメソッドが実行されました");
        }

        public  void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine("CheerfulPet.Sleepメソッドが実行されました");
        }

    }
}
