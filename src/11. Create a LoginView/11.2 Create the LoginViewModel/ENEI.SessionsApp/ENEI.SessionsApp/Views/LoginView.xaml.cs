using ENEI.SessionsApp.ViewModels;
using Xamarin.Forms;

namespace ENEI.SessionsApp.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
