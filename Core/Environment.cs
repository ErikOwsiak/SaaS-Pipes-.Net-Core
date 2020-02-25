
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace SAASP.Core
{
   public class Environment
   {

      public Environment()
      {
         /* load dlls */

      }

      public ILogger Logger
      {
         get { return null; }
      }

      public IPerfCounters PerfCounters
      {
         get { return null; }
      }

   }
}
