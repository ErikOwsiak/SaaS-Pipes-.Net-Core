
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;


namespace SAASP.Core
{
   public class SysSettings
   {
      public DirectoryInfo CurrentFolder
      {
         get
         {
            return new DirectoryInfo(System.Environment.CurrentDirectory);
         }
      }
   }
}
