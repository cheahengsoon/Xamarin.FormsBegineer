using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormPortable
{
    public partial class Animation : ContentPage
    {
        public Animation()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender,EventArgs e)
        {
            MainGrid.TranslateTo(200, 300, 1000, Easing.Linear);
        }
    }
}
