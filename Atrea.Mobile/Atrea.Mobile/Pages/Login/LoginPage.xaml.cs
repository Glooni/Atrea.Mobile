using Atrea.Mobile.Pages.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Atrea.Mobile
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
            loginPageBtn.Clicked += LoginPageBtn_Clicked;
            forgotPageBtn.Clicked += ForgotPageBtn_Clicked;
		}

        private async void LoginPageBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage());
        }

        private async void ForgotPageBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPage()); 
        }
    }
}
