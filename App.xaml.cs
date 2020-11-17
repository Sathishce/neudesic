using Neudesic.View;
using Neudesic.View.Tablet;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Neudesic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Device.Idiom == TargetIdiom.Tablet)
            {
                MainPage = new NavigationPage(new TabletListPage());
            }
            else 
            {
               MainPage = new NavigationPage(new Listpage());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
