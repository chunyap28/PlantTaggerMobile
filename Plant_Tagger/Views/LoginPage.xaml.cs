using System;
using Xamarin.Forms;
using Plant_Tagger.Services;

namespace Plant_Tagger.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            //xEmailTB.FontAwesomeLabel = FontAwesome.FAEnvelope;
            //xPasswordTB.FontAwesomeLabel = FontAwesome.FALock;
        }

        async void OnSignInRequested(object sender, EventArgs e){
            IsBusy = true;
            AuthService AuthServ = new AuthService();
            String result = await AuthServ.Login( xEmailTB.Text, xPasswordTB.Text );
            System.Diagnostics.Debug.WriteLine("Result: " + result);
            IsBusy = false;
        }
    }
}
