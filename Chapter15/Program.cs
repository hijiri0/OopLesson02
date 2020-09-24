using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        static void Main(string[] args)
        {
            BmiCalculator bmiCalculator = new BmiCalculator();

            //var Height = 0;
            //var Weight = 0;

            double height,weight;


            //Console.Write("身長(cm):");
            ////Height= int.Parse(Console.ReadLine());
            

            string line;
            while (true)
            {
                Console.Write("身長(cm):");
                line = Console.ReadLine();
                if (double.TryParse(line, out height))
                    break;
                Console.WriteLine("正しい値を入力してください");
            }

            Console.Write("体重(kg):");
            //weight = int.Parse(Console.ReadLine());
             line = Console.ReadLine();
            if (!double.TryParse(line, out weight))
            {
                Console.WriteLine("変換エラー(体重を70kgに設定します)");
                weight = 70;
            }


            Console.WriteLine($"BMIは{bmiCalculator.GetBmi(height, weight):F1}");
            
           
        }
    }
}
