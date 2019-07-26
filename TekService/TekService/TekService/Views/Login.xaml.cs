using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TekService.Views
{
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

        private void Button_Clicked(object sender, EventArgs e)
        {


        }
    }
}