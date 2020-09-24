using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    class SleepyPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public SleepyPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }

        public  void Eat()
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine("SleepyPet.Eatメソッドが実行されました");
        }

        public  void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine("SleepyPet.Playメソッドが実行されました");
        }

        public  void Sleep()
        {
            Mood += 2;
            Energy += 2;
            Console.WriteLine("SleepyPet.Sleepメソッドが実行されました");
        }

    }
}
