using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpecialiseringsProjekt
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        string scanned;

        private async void QR_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQR>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    scanned = result;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
