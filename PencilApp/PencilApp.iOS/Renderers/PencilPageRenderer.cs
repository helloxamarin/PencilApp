using System;
using System.Collections.Generic;
using System.Text;
using PencilApp.iOS.Renderers;
using PencilApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(PencilPage), typeof(PencilPageRenderer))]
namespace PencilApp.iOS.Renderers
{
    public class PencilPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            var element = e.NewElement;

            
            
        }
    }
}
