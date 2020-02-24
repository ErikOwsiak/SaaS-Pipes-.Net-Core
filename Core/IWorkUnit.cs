
using System;
using System.Collections.Generic;
using System.Text;


namespace SAASP.Core
{
   public interface IWorkUnit
   {
      object Poke(string key = null);
      bool SetEnv(Environment e);
      /* only these are called by the engine */
      bool Init(object o = null);
      bool Exec(object o = null);
      bool Report(object o = null);
      bool Cleanup(object o = null);
   }
}
