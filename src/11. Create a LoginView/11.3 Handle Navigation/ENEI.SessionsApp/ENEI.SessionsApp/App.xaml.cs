using ENEI.SessionsApp.Model;
using ENEI.SessionsApp.Views;
using Xamarin.Forms;

namespace ENEI.SessionsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginView())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.Black,
                BackgroundColor = Color.White,
            };

            MessagingCenter.Subscribe<NavMessage>(this, "Navigation", navMessage =>
            {
                switch (navMessage.Page)
                {
                    case "login":
                        MainPage = new LoginView();
                        break;
                    case "sessions":
                        MainPage = new NavigationPage(new SessionsView())
                        {
                            BarBackgroundColor = Color.White,
                            BarTextColor = Color.Black,
                            BackgroundColor = Color.White,
                        };
                        break;
                    case "details":
                        MainPage.Navigation.PushAsync(new SessionDetailsView(navMessage.Param as Session), true);
                        break;
                }
            });
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
