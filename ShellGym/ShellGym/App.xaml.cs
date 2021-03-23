﻿using Xamarin.Forms;

namespace ShellGym
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutAppShell();
            //MainPage = new TabsAppShell();
            //MainPage = new NavigationAppShell();
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