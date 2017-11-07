using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PencilApp.Views.Controls
{
    public class ButtonLabel : Label
    {
        public event EventHandler Tapped;

        public ButtonLabel()
        {
            var tabGestureRecognizer = new TapGestureRecognizer();
            tabGestureRecognizer.Tapped += (sender, args) => RaiseTapped();
            GestureRecognizers.Add(tabGestureRecognizer);
        }

        public void RaiseTapped() => Tapped?.Invoke(this, EventArgs.Empty);
    }
}
