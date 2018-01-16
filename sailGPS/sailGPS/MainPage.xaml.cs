using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sailGPS
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Padding = new Thickness(10, Device.OnPlatform(20, 5, 5), 10, 10);

		}
	}
}
