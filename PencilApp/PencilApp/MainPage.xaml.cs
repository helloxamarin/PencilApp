using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PencilApp.Views;
using Xamarin.Forms;

namespace PencilApp
{
	public partial class MainPage : ContentPage
	{
	    private int _tappedCount = 0;

		public MainPage()
		{
			InitializeComponent();
		}

	    private void ButtonLabel_OnTapped(object sender, EventArgs e)
	    {
	        _tappedCount++;
	        CountLabel.Text = "Tapped Count : " + _tappedCount;
	    }

	    private void GoPencilPage(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new PencilPage());
	    }
    }
}
