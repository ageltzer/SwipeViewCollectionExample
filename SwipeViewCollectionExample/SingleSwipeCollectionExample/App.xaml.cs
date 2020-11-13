using SingleSwipeCollectionExample.Pages;
using Xamarin.Forms;

namespace SingleSwipeCollectionExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SwipeViewCollectionPage());
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
