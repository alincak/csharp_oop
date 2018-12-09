using System;

namespace Methods
{
   class Program
   {
      static void Main(string[] args)
      {
         MyWriteLine(Sum(10, 5));
      }

      static int Sum(int x, int y) // Sum-int-int
      {
         var _sum = x + y;
         return _sum;
      }

      //static int Sum(int x, int y) // Sum-int-int // Error
      //{
      //   var _sum = x + y;
      //   return _sum;
      //}

      static void MyWriteLine(int s)
      {
         //Sadece yapması gereken işi yapar.
         Console.WriteLine(s);
      }

   }
}
