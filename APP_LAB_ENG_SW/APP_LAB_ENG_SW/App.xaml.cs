using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP_LAB_ENG_SW
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Login());//Criando uma NavigationPage para nossa aplicação
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
