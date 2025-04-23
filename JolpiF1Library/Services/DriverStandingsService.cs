using JolpiF1Library.Model;
using JolpiF1Library.Models;
using JolpiF1Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Services
{
    class DriverStandingsService : IApiService
    {
        DriverStandingsModel currentDriverStandings;
        private string _apiResponse;

        private string _endpoint = "driverstandings";


        public async Task GetData(HttpClient ApiClient)
        {
            // using (HttpResponseMessage response = await ApiClient.GetAsync("https://api.jolpi.ca/ergast/f1/current/driverstandings/"))
            using (HttpResponseMessage response = await ApiClient.GetAsync($"{_endpoint}/"))
            {
                if (response.IsSuccessStatusCode)
                {
                    currentDriverStandings = await response.Content.ReadAsAsync<DriverStandingsModel>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public string ProcessResponse()
        {

            List<DriverInfoModel> listDriverInfo = new List<DriverInfoModel>();
            var driverStandingList = currentDriverStandings.MRData.StandingsTable.StandingsLists[0].DriverStandings;

            foreach (var standing in driverStandingList)
            {
                listDriverInfo.Add(new DriverInfoModel
                {
                    Position = standing.Position,
                    Name = $"{standing.Driver.GivenName} {standing.Driver.FamilyName}",
                    Constructor = standing.Constructors[0].Name
                });
            }
            return GetFormattedDriverStanding(listDriverInfo);
        }

        private string GetFormattedDriverStanding(List<DriverInfoModel> listDriverInfo)
        {
            StringBuilder formatedText = new StringBuilder();
            formatedText.AppendLine("Current Driver Standings:");

            foreach (var driverinfo in listDriverInfo)
            {
                formatedText.AppendLine($"{driverinfo.Position}. {driverinfo.Name} [{driverinfo.Constructor}]");
            }

            return formatedText.ToString();
        }
    }
}
