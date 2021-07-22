using CoursesMobile.Helpers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoursesMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageView2();
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
