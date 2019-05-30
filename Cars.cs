using System;
using System.Collections.Generic;
using System.Text;

namespace Programs1
{
    class Cars
    {
        public string make { set; get; }
        public string model { set; get; }
        public string color { set; get; }
        public int hp { set; get; }
        public double engine { set; get; }
        public int year { set; get; }

        public Cars(string aModel, string aColor, string aMake, int aYear, int aHP, double aEngine)
        {
            model = aModel;
            make = aMake;
            year = aYear;
            hp = aHP;
            engine = aEngine;
            color = aColor;

        }
        public  bool IsFast()
        {
            if ( hp >= 240)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public bool IsOld()
        {
            if (year <= 2000)
            {
                return true;
                
            }
            else
            {
                return false;
            }

        }
        public void Classic()
        {
            if (make == "BMW")
            {
                Console.WriteLine("This is a very nice car tis indeed a classic");
            }
            else
            {
                Console.WriteLine("Maybe you should consider and upgrade son, you are riding in a bucket");
            }
            
        }
    }
}
