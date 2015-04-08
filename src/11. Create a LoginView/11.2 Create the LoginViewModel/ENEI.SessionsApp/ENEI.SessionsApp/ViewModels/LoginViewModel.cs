
using System.Windows.Input;
using Xamarin.Forms;

namespace ENEI.SessionsApp.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            LoginCommand =new Command(DoLogin);
        }

        private void DoLogin(object param)
        {
            var option = param.ToString();
            switch (option)
            {
                case "facebook":
                 //connect with facebook api
                    break;
                case "goolge":
                 //connect with google api
                    break;
                case "microsoft":
                 //connect with microsoft api
                    break;
            }
        }

        public ICommand LoginCommand { get; set; }
    }
}
