using System;
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
            IsBusy = false;

            //xEmailTB.FontAwesomeLabel = FontAwesome.FAEnvelope;
            //xPasswordTB.FontAwesomeLabel = FontAwesome.FALock;
        }

        protected override async void OnAppearing()
        {
            var content = this.Content;
            this.Content = null;
            this.Content = content;

            var vm = BindingContext as LoginPageModel;
        }

        async void OnSignInRequested(object sender, EventArgs e){
            IsBusy = true;
            AuthService AuthServ = new AuthService();
            try{
                String result = await AuthServ.Login(xEmailTB.Text, xPasswordTB.Text);    
                System.Diagnostics.Debug.WriteLine("Result: " + result);
            }catch(Exception ex){
                await DisplayAlert("Alert", ex.Message, "OK");
            }

            IsBusy = false;
        }

        async void OnSignUpRequested(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}
