using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace TekService.Views
{
    public class MasterPageItems
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }


        public static IList<MasterPageItems> MenuList { get; set; }


        static MasterPageItems()
        {
            MenuList = new ObservableCollection<MasterPageItems>
            {
                new MasterPageItems()
                {
                    Title="Takvim",
                    Icon="calender_gray.png",
                    TargetType = typeof(Calender),

                },
                new MasterPageItems()
                {
                    Title="Servis",
                    Icon="service_gray.png",
                    TargetType = typeof(Calender),

                },
                new MasterPageItems()
                {
                    Title="Hakkında",
                    Icon="about_gray.png",
                    TargetType = typeof(Calender),

                },
                new MasterPageItems()
                {
                    Title="Çıkış",
                    Icon="Exit_gray.png",
                    TargetType = typeof(Calender),

                }
            };
        }
        public NavigationPage GetDetailPage<T>()
        {
            return new NavigationPage((Page)Activator.CreateInstance(typeof(T)));
        }


    }
    public static class Extens
    {
        public static NavigationPage GetDetailPage(this MasterPageItems source)
        {
            return new NavigationPage((Page)Activator.CreateInstance(source.TargetType));
        }

    }
}
