
using System;
using sc = SAASP.Core;


namespace Runner
{
   class Program
   {
      static void Main(string[] args)
      {
         sc.Starter starter = new sc.Starter();
         starter.LoadPipes();

         Console.WriteLine("Hello World!");
      }
   }
}
