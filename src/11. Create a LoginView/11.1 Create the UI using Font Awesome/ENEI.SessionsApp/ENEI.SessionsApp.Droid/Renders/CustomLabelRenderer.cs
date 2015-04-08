using Android.Graphics;
using Android.Widget;
using ENEI.SessionsApp.Controls;
using ENEI.SessionsApp.Droid.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace ENEI.SessionsApp.Droid.Renders
{
    public class CustomLabelRenderer: LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var label = (TextView)Control;
            Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "FontAwesome.ttf");
            label.Typeface = font;
        }
    }
}