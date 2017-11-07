using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using PencilApp.UWP.Renderers;
using PencilApp.Views;
using Xamarin.Forms.Platform.UWP;
using Button = Windows.UI.Xaml.Controls.Button;
using Page = Xamarin.Forms.Page;

[assembly:ExportRenderer(typeof(PencilPage), typeof(PencilPageRenderer))]
namespace PencilApp.UWP.Renderers
{
    public class PencilPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            var element = e.NewElement;
            var control = Control;

            var button = new Button()
            {
                Content = "나이키"
            };
            this.SetNativeControl(new InkCanvasPage());


        }
    }
}
