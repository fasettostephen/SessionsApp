
using Xamarin.Forms;

namespace ENEI.SessionsApp.Controls
{
    public class CustomLabel:Label
    {
        public CustomLabel()
		{
           FontFamily = Device.OnPlatform(
               iOS: "FontAwesome", 
               Android: null,
               WinPhone:@"\Assets\Fonts\FontAwesome.ttf#FontAwesome");

            if (Device.OS == TargetPlatform.Windows)
            {
                FontFamily = @"\Assets\Fonts\FontAwesome.ttf#FontAwesome";
            }
		}
    }
}
