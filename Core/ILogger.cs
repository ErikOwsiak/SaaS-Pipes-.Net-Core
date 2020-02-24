
using System;
using System.Collections.Generic;
using System.Text;


namespace SAASP.Core
{
   public interface ILogger
   {
      bool Init(string flags);
      bool WriteInfo(string msg);
      bool WriteWarn(string msg);
      bool WriteErr(string msg);
   }
}
