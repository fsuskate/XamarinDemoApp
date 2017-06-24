﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dataViewModel = this.BindingContext as DataViewModel;
            string message = $"Welcome {dataViewModel.UserName} to Zombocom";
            DisplayAlert("Login Successful", message, "Ok");
        }

    }
}
