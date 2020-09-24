using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Chapter10
{
    #region
    class Book
    {
        //自動実装プロパティ(P293)
        public string Title { get; set; }
        public string Author{ get; set; }
        public int Pages { get; set; }
        //public int Rating{ get; set; }

         int _rating;//フィールドの定義
        public int Rating
        {
            get//get アクセサ
            {
                return _rating;
            }

            set//setアクセサ
            {
                if(value<=1)
                {
                    _rating = 1;
                }
                else if(value>=6)
                {
                    _rating = 5;
                }
                else
                {
                    _rating = value;//
                }
               
            }

        }

        public void Print()
        {
            Console.WriteLine($"■{this.Title}");
            Console.WriteLine($"{this.Author}{this.Pages}ページ　評価:{this.Rating}");
        }
        
    }
    #endregion

}
