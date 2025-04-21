using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Services.Interfaces
{
    public interface IApiService
    {

        public Task GetData(HttpClient ApiClient);

        public string ProcessResponse();

    }
}
