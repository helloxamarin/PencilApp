using Android.Widget;
using PencilApp.Droid.Renderers;
using PencilApp.Views.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ButtonLabel), typeof(ButtonLabelRenderer))]
namespace PencilApp.Droid.Renderers
{
    public class ButtonLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Label element = e.NewElement;
            TextView control = Control;

            control.Text = element.Text + " in Android";
        }
    }
}