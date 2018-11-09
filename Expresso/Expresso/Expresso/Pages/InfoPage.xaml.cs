using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expresso.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
		public InfoPage ()
		{
			InitializeComponent ();
		}

	    private void TapFacebook_OnTapped(object sender, EventArgs e)
	    {
            Device.OpenUri(new Uri("https://www.facebook.com/Expresso-2291246571109615"));
	    }

	    private void TapTwitter_OnTapped(object sender, EventArgs e)
	    {
	        Device.OpenUri(new Uri("https://www.facebook.com/Expresso-2291246571109615"));

        }

        private void TapInstagram_OnTapped(object sender, EventArgs e)
	    {
	        Device.OpenUri(new Uri("https://www.facebook.com/Expresso-2291246571109615"));

        }

        private void TapYoutube_OnTapped(object sender, EventArgs e)
	    {
	        Device.OpenUri(new Uri("https://www.facebook.com/Expresso-2291246571109615"));

        }

	    private void TapCall_OnTapped(object sender, EventArgs e)
	    {
            PhoneDialer.Open("996545231232");
	    }
	}
}