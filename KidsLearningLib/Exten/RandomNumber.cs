using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearningLib.Exten
{
    //https://www.thaicreate.com/dotnet/forum/125604.html
    public static class RandomNumber
    {
        /* public double StartNumber = 0;
         public double EndNumber = 0;

         private List<double> Numbers;
         private Random r = new Random();
         public RandomNumber()
         {
             InitNumber();
         }
         public RandomNumber(int min, int max)
         {
             StartNumber = min; EndNumber = max;
             InitNumber();
         }
         public RandomNumber(double min, double max)
         {
             StartNumber = min; EndNumber = max;
             InitNumber();
         }
         private void InitNumber()
         {
             if (StartNumber == 0 && EndNumber == 0) return;
             if (Numbers == null) Numbers = new List<double>();
             for (double i =StartNumber; i <= EndNumber; i++)
                 this.Numbers.Add(i);
         }

         public void Start()
         {
             InitNumber();
         }

         public void Reset()
         {
             this.Numbers.Clear();
         }

         public int NextNumber()
         {
             int randomIndex = r.Next(this.Numbers.Count);
             int number = Convert.ToInt32( this.Numbers[randomIndex]);
             this.Numbers.RemoveAt(randomIndex);
             return number;
         }
         public double NextDouble()
         {
             int randomIndex = r.Next(this.Numbers.Count);
             double number = this.Numbers[randomIndex];
             this.Numbers.RemoveAt(randomIndex);
             return number;
         }*/

        private static Random r = new Random();
        public static int NextNumber(int min, int max)
        {
            return r.Next(min,max);
            System.Threading.Thread.Sleep(1000);
        }
        public static double NextNumber(double min, double max)
        {
            return r.Next(Convert.ToInt32(min), Convert.ToInt32(max))  +  r.NextDouble();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
