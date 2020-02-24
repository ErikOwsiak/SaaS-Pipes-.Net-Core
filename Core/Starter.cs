
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;


namespace SAASP.Core
{
   public class Starter
   {
      public Starter()
      {

      }

      public void LoadPipes(string xmlfile = "pipelines.xml")
      {
         if (!File.Exists(xmlfile))
            throw new FileNotFoundException(xmlfile);
         XmlDocument xdoc = new XmlDocument();
         xdoc.Load(xmlfile);
         /* load pipelines */
         XmlNodeList xmlNodeList = xdoc.DocumentElement.GetElementsByTagName("pipeline");
         foreach (XmlNode node in xmlNodeList)
            this.StartPipeline(node);
      }

      public bool StartPipeline(XmlNode node)
      {

         return true;
      }
   }
}
