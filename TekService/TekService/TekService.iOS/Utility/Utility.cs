using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(TekService.iOS.Utility.Utility))]
namespace TekService.iOS.Utility
{
    using TekService.Utility; 
    public class Utility : IAppVersion
    {
        public string GetVersion()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        }
        public int GetBuild()
        {
            return int.Parse(NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString());
        }

    }
}