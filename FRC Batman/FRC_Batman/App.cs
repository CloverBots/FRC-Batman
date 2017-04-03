using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using FRC_Batman.Core;

namespace FRC_Batman
{
    public class App : Application
    {
        public App()
        {
            MainPage = new SplashScreen();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage = new MainPage();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
