using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormPortable
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new Page1(lable1.Text));
        }
    }
}
