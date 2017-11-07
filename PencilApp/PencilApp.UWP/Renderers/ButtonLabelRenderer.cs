using Windows.UI.Xaml.Controls;
using PencilApp.UWP.Renderers;
using PencilApp.Views.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ButtonLabel), typeof(ButtonLabelRenderer))]
namespace PencilApp.UWP.Renderers
{
    public class ButtonLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Label element = e.NewElement;
            TextBlock control = Control;

            if (element != null && control != null)
            {
                control.Text += " in UWP";
            }
        }
    }
}
