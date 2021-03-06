﻿using System;
using Xamarin.Forms;
using Plant_Tagger.Services;
using Plant_Tagger.ViewModels;

namespace Plant_Tagger.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = this.Content;
            this.Content = null;
            this.Content = content;

            var vm = BindingContext as LoginPageModel;
        }
    }
}
