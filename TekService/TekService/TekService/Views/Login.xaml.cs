using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TekService.Views
{
    using TekService.API;
    using static  Data.imageConverter;
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        Data.imageConverter imageConverter = new Data.imageConverter();
        public Login ()
		{
            InitializeComponent ();
            logo.BindingContext = "logo2.png";
            
		}

        private void SwHatırla_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var sonuc = await Member.LoginAsync(new API.Request.MemberRequest()
            {
                EmailAddress =txtKullanıcıAdı.Text,
                Password=txtŞifresi.Text,
                Device = new API.Request.Device()
                {
                    
                }
            });

            if (sonuc.Header.HasError )
            {
               await  DisplayAlert("Hata", $"{sonuc.Header.Message}\nCode:{sonuc.Header.ErrorCode}", "Tamam");
            }
            else
            {
                await DisplayAlert("Giriş", $"Hoşgeldin:{sonuc.FirstName} {sonuc.LastName}", "Tamam");

            }
        }
    }
}