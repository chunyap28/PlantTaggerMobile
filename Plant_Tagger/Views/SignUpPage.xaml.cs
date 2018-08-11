using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Plant_Tagger.ViewModels;

namespace Plant_Tagger.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = this.Content;
            this.Content = null;
            this.Content = content;

            var vm = BindingContext as SignUpPageModel;
        }
    }
}
