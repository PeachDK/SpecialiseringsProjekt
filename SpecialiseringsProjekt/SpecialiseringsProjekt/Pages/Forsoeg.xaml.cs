using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpecialiseringsProjekt.Dal;

namespace SpecialiseringsProjekt.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Forsoeg : ContentPage
	{
        public async Task OnItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem;

            var itemPage = new Item();
            itemPage.BindingContext = item;
            await Navigation.PushAsync(itemPage);
            
            
        }

        public Forsoeg ()
		{
			InitializeComponent ();
            listView.ItemsSource = Repo.StaticInstance.GetForsoeg();
            
		}
	}
}