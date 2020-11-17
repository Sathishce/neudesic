using Neudesic.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Service
{
    [Headers("User-Agent : request:")]
    public interface iListAPI
    {
        [Get("/rest/v2/all")]
       // Task<List<neudesicListModel>> GetList();
      Task<List<neudesicListapiModel>> GetList();
    }
}
