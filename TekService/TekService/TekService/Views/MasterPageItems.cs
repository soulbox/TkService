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
        public PageType pageType { get; set; }
        public  TabbedPage tabs { get; set; }
        public static IList<MasterPageItems> MenuList { get; set; }
        public enum PageType
        {
            tabbed,
            Single,
            none
        }
        public static TabbedPage GetCalenderTabbedPage()
        {
            var CalenderTabs = new TabbedPage() { Title = "Takvim" };

            CalenderTabs.Children.Add(new Calender.today() {Title="Bugün" ,IconImageSource="icon"});
            CalenderTabs.Children.Add(new Calender.Tomarrow() { Title = "Yarın", IconImageSource = "icon" });
            CalenderTabs.Children.Add(new Calender.MoreDays() { Title = "+15", IconImageSource = "icon" });
            return CalenderTabs;
        }
        public static TabbedPage GetServiceTabbedPage()
        {
            var ServiceTabs = new TabbedPage() { Title = "Servis"};
            ServiceTabs.Children.Add(new Service.History() { Title = "Anlık", IconImageSource = "icon" });
            ServiceTabs.Children.Add(new Service.New() { Title = "Yeni", IconImageSource = "icon" });
            ServiceTabs.Children.Add(new Service.Open() { Title = "Açık", IconImageSource = "icon" });
            ServiceTabs.Children.Add(new Service.Test() { Title = "Test", IconImageSource = "icon" });
            ServiceTabs.Children.Add(new Service.Solved() { Title = "Çözüldü", IconImageSource = "icon" });
            return ServiceTabs;
        }


        static MasterPageItems()
        {


            MenuList = new ObservableCollection<MasterPageItems>
            {
                new MasterPageItems()
                {
                    Title="Takvim",
                    Icon="calender_gray.png",
                    pageType=PageType.tabbed,
                    tabs= GetCalenderTabbedPage()
                },
                new MasterPageItems()
                {
                    Title="Servis",
                    Icon="service_gray.png",
                    pageType=PageType.tabbed,
                    tabs= GetServiceTabbedPage()

                },
                new MasterPageItems()
                {
                    Title="Hakkında",
                    Icon="about_gray.png",
                    pageType=PageType.Single  ,
                    TargetType = typeof(Calender.Calender),

                },
                new MasterPageItems()
                {
                    Title="Çıkış",
                    Icon="Exit_gray.png",
                    pageType=PageType.none,
                    TargetType = typeof(Calender.Calender),

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
