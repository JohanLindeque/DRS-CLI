using JolpiF1Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Services
{
    class DriverStandingsService : IApiService
    {
        private string _apiResponse;

        private string _endpoint = "2025/driverstandings/";


        public void GetData(HttpClient ApiClient)
        {
            throw new NotImplementedException();
        }

        public string ProcessResponse()
        {
            return _apiResponse;
        }
    }
}
