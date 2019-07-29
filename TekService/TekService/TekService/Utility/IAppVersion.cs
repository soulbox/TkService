using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.Utility
{
    public interface IAppVersion
    {
        string GetVersion();
        int GetBuild();
   
    }
}
