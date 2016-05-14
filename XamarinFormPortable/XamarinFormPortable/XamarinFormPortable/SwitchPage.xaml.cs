using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormPortable
{
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void Switch_OnToggled(object sender,ToggledEventArgs e)
        {
           bool isToggeled= e.Value;

            MainLabel.Text = isToggeled.ToString();
        }
    }
}
