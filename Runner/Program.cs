
using System;
using __SAASP = SAASP.Core;


namespace Runner
{
   class Program
   {
      static void Main(string[] args)
      {
         __SAASP.Starter starter = new __SAASP.Starter();
         starter.LoadPipes();

         Console.WriteLine("Hello World!");
      }
   }  B
}
