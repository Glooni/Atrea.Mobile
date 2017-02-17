using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Atrea.Mobile.Pages.Login
{
    public partial class ModalPage : ContentPage
    {
        public ModalPage()
        {
            Title = "Modal Page";
            Button backButton = new Button
            {
                Text = "Back",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            backButton.Clicked += BackButton_Clicked;
            Content = backButton;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
