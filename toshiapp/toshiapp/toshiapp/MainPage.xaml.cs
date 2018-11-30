using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace toshiapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

        public void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GeneratorPage());
        }
    }
}