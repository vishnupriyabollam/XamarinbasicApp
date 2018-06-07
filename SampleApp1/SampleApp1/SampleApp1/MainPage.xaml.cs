using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

          async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleApp1.BookDetails());
            
        }

        async void NextButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleApp1.bookDetails2());

        }

    }
}
