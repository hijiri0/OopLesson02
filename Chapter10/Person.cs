using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class Person
    {
        public string FirstName { get; set; } = "太郎"; //プロパティの初期可
        public string LastName { get; set; } = "池田";  //
       
        public string FullName
        {
            get { return LastName + FirstName; }
        }
        

        //public string GetFullName()
        //{
        //    return LastName + FirstName;
        //}

        public string AddTitele(string title ="様")
        {
            return $"{LastName }{FirstName}{title}";
        }
    }
}
