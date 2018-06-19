using System;
using Plant_Tagger.ViewModels.Base;
using Plant_Tagger.Validations;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Plant_Tagger.ViewModels
{
    public class LoginPageModel : ViewModelBase
    {
        private ValidatableObject<string> _userName;
        private ValidatableObject<string> _password;

        public ICommand ValidateUserNameCommand => new Command(() => ValidateUserName());

        public LoginPageModel(){
            //AddValidations();
        }

        public override Task InitializeAsync(object navigationData){
            return base.InitializeAsync(navigationData);
        }

        public ValidatableObject<string> UserName{
            get { 
                return _userName; 
            }
            set { 
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

        public ValidatableObject<string> Password{
            get{
                return _password;
            }
            set{
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        private bool ValidateUserName()
        {
            return _userName.Validate();
        }

        private bool ValidatePassword()
        {
            return _password.Validate();
        }

        private void AddValidations()
        {
            _userName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A username is required." });
            _password.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A password is required." });
        }
    }
}
