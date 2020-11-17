using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Neudesic.View.Tablet
{
    class TabletListPage : MasterDetailPage
    {
        public TabletListPage()
        {
            Title = "Countries";

            this.MasterBehavior = MasterBehavior.Default;

            Master = new Listpage();

            Detail = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label { Text = "Select a Country", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }
                    }
                }
            };

            ((Listpage)Master).ActionDetails = (neudesicListapiModel) =>
            {
                Detail = new ListDetails(neudesicListapiModel);
                if (Device.RuntimePlatform != Device.UWP)
                    IsPresented = false;
            };

            IsPresented = true;
           
        }

    }
}
