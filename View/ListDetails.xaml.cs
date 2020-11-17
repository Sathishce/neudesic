using Neudesic.Model;
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
    public partial class ListDetails : ContentPage
    {
        public ListDetails(neudesicListapiModel mymodel)
        {
            InitializeComponent();
            MyItemName.Text = mymodel.name;
            MyItemLanguage.Text = mymodel.languages[0].name;
            MyItemNativename.Text = mymodel.nativeName;
            MyItemArea.Text = mymodel.area.ToString();
            MyItemRegion.Text = mymodel.region;
            MyItemsPopulation.Text = mymodel.population.ToString();
            MyItemNumericCode.Text = mymodel.numericCode.ToString();
            MyItemDetails.Text = "Capital : " + mymodel.capital + "( Currency :" + mymodel.currencies[0].code + "(" + mymodel.currencies[0].symbol + "))";
            MyImageC.Source = new UriImageSource()
            {
                Uri = new Uri(mymodel.flag)
            };
        }
    }
}