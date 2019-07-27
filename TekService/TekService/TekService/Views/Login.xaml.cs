using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TekService.Views
{
    using Plugin.Connectivity;
    using TekService.API;
    using static Data.imageConverter;
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        Data.imageConverter imageConverter = new Data.imageConverter();
        public Login()
        {
            InitializeComponent();
            logo.BindingContext = "logo2.png";

        }

        private void SwHatırla_Toggled(object sender, ToggledEventArgs e)
        {

        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {

            if ( !CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("Hata", $"İnternet Bağlantınızı Açınız!.", "Tamam");
                return;
            }
            if (string.IsNullOrEmpty(txtKullanıcıAdı.Text )  | string.IsNullOrEmpty(txtŞifresi.Text))
            {
                await DisplayAlert("Hata", $"Lütfen tüm alanları doldurunuz!.", "Tamam");
                return;
            }
            if (!IsValidEmail(txtKullanıcıAdı.Text))
            {
                await DisplayAlert("Hata", $"Lütfen Geçerli bir E-Posta adresi girin.", "Tamam");
                return;
            }

            activator.IsRunning = true;
            var sonuc = await APIManager.Member.LoginAsync(new API.Request.MemberRequest()
            {
                EmailAddress = txtKullanıcıAdı.Text,
                Password = txtŞifresi.Text,
                Device = new API.Request.Device()
                {

                }
            });

            if (sonuc.Header.HasError)
            {
                await DisplayAlert("Hata", $"{sonuc.Header.Message}\nCode:{sonuc.Header.ErrorCode}", "Tamam");
            }
            else
            {
                await DisplayAlert("Giriş", $"Hoşgeldin:{sonuc.FirstName} {sonuc.LastName}", "Tamam");
                MasterPage fpm = new MasterPage(sonuc)
                {
                    Detail = new NavigationPage(new Calender())
                };
                Application.Current.MainPage = fpm;
            }
        }
    }
}