using Neudesic.Model;
using Neudesic.Service;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.ViemModel
{
    public interface iasyncInit
    {
        Task initialization { get; }
    }
   
    class MyListViewModel : iasyncInit
    {
        iListAPI myapi;
       
        public ObservableCollection<neudesicListapiModel> myListmodel { get; set; }
        List<neudesicListapiModel> mylist { get; set; }
        public Task initialization { get; private set; }
       
        public MyListViewModel()
        {
            myListmodel = new ObservableCollection<neudesicListapiModel>();
            initialization = Initasync();
           
        }

        private async Task Initasync()
        {
            try
            {
                myapi = RestService.For<iListAPI>("https://restcountries.eu");
                var list = await myapi.GetList();
                mylist = await myapi.GetList();

                myListmodel.Add(new neudesicListapiModel { name = "xyx", capital = "fdfdfdfdd", flag = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5IuuphdrvMOOtPtQtFwl90MDkunJ7v6iwTw&usqp=CAU" });
                foreach (var myModel in mylist)
                {
                    myListmodel.Add(myModel);
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
