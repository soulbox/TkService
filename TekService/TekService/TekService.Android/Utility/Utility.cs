using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TekService.Droid.Utility;


[assembly: Xamarin.Forms.Dependency(typeof(Utility))]
namespace TekService.Droid.Utility
{
    using Android.Content.PM;
    using TekService.Utility;
    public class Utility : IAppVersion
    {
        

        public string GetVersion()
        {
            var vers = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var context = global::Android.App.Application.Context;

            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);
            return info.VersionName;
            //return vers.ToString();

        }

        public int GetBuild()
        {
            var context = global::Android.App.Application.Context;
            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);
            return info.VersionCode;
        }
    }
}