using System;
using SingleSwipeCollectionExample.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SingleSwipeCollectionExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SwipeViewCollectionPage();
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
