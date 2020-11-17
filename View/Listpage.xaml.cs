using Neudesic.Model;
using Neudesic.ViemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Neudesic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listpage : ContentPage
    {
        public Action<neudesicListapiModel> ActionDetails;
        public Listpage()
        {
            InitializeComponent();
            BindingContext = new MyListViewModel();


        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as neudesicListapiModel;
            if (ActionDetails == null)
            {
                await Navigation.PushAsync(new ListDetails(details));
            }
            else
            {
                ActionDetails.Invoke(details);
            }
        }
    }
}