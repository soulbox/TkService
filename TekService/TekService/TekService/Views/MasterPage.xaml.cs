using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekService.API.Result;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekService.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public static  MasterPageItems  CurrentPage { get; set; }
        public MasterPage(MemberResponse response)
        {
            InitializeComponent();
            logo.BindingContext = "logo2.png";
            navigationDrawerList.ItemsSource = MasterPageItems.MenuList;
            title.Text = response.AccountTitle;
            account.Text = $"{response.FirstName } { response.LastName}";
        }

        private async void NavigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CurrentPage = (MasterPageItems)e.SelectedItem;           
            Type page = CurrentPage.TargetType;

            switch (CurrentPage.pageType)
            {
                case MasterPageItems.PageType.tabbed:
            
                    CurrentPage .Title = CurrentPage.Title;
                    Detail =  new NavigationPage(CurrentPage.tabs);
                    IsPresented = false;
                    break;
                case MasterPageItems.PageType.Single:
                    var navpage = (Page)Activator.CreateInstance(page);
                    navpage.Title = CurrentPage.Title;
                    Detail =  new NavigationPage(navpage);
                    IsPresented = false;
                    break;
                case MasterPageItems.PageType.none:
                    if (!CurrentPage.Title.Contains("Çıkış"))
                    {
                        var isOk = await DisplayAlert("Durum", "Çıkmak istediğinize eminmisiniz?", "Evet", "Hayır");
                        if (isOk)
                        {
                            Application.Current.MainPage = new Login();
                        }
                    }

                    break;
                default:
                    break;
            }

           
        }
    }
}