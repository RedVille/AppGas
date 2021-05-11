﻿using AppGas.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppGas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GasStationsListView();
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
