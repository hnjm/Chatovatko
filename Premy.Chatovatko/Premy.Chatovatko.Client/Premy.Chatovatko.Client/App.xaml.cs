﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Premy.Chatovatko.Client.Views;
using System.Reflection;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Premy.Chatovatko.Client
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            

            MainPage = new CertificateSelection();
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
