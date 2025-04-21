using JolpiF1Library.Model;
using JolpiF1Library.Services;
using JolpiF1Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Utilities
{
    public static class ApiHelper
    {
        private static readonly IApiService _apiService;
        public static HttpClient ApiClient { get; set; } 
        private static readonly string  _baseURL = "https://api.jolpi.ca/ergast/f1/";

        private static string _respond;

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri(_baseURL);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


        }

        public static string GetDriverStandings()
        {
            DriverStandingsService driverStandingEndpoint = new DriverStandingsService();
            driverStandingEndpoint.GetData(ApiClient);
            _respond = driverStandingEndpoint.ProcessResponse();
            return _respond;
        }



    }
}
