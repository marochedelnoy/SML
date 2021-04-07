using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SML.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Button_Clicked_GitHub(object sender, EventArgs e)
        {
            var url = "https://github.com/marochedelnoy/SML";
            Device.OpenUri(new Uri(url));
        }
    }
}