using Foundation;
using PencilApp.iOS.Renderers;
using PencilApp.Views.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ButtonLabel), typeof(ButtonLabelRenderer))]
namespace PencilApp.iOS.Renderers
{
    public class ButtonLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Label element = e.NewElement;
            UILabel control = Control;
            if (element != null && control != null)
            {
                control.AttributedText = new NSAttributedString(
                    element.Text + " in iOS", underlineStyle: NSUnderlineStyle.Single);
            }
        }
    }
}
