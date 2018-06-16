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
		public Forsoeg ()
		{
			InitializeComponent ();
            listView.ItemsSource = Repo.StaticInstance.GetForsoeg();
            
		}
	}
}