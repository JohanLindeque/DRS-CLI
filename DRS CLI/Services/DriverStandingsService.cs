using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRS_CLI.Services
{
    class DriverStandingsService
    {
        HttpClient client = new HttpClient();

        private string _baseURL = "https://api.jolpi.ca/ergast/f1/2025/driverstandings/";


        public void GetDriverStandings()
        {
            client.BaseAddress = new Uri(_baseURL);
            var  repsonse = client.GetAsync().Result;
        }

    }
}
