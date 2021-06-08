using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LukePonga_Portfolio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var browser = new WebView();
            browser.Source = "https://www.lukeponga.website/";
            Content = browser;
        }
    }
}
