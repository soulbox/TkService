using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.Utility
{
   public  class AppVersion
    {
        public static Version GetVersion { get => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; } 
       
    }
}
