using JolpiF1Library.Models;
using JolpiF1Library.Models.API_Response;
using JolpiF1Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Services
{
    class SeasonRacesService : IApiService
    {
        SeasonRacesModel currentSeasonRaces;
        private string _endpoint = "races";

        public async Task GetData(HttpClient ApiClient)
        {
            using (HttpResponseMessage response = await ApiClient.GetAsync(_endpoint))
            {
                if (response.IsSuccessStatusCode)
                {
                    currentSeasonRaces = await response.Content.ReadAsAsync<SeasonRacesModel>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public string ProcessResponse()
        {
            List<SeasonRaceInfoModel> listSeasonRaces = new List<SeasonRaceInfoModel>();
            var seasaonRacesList = currentSeasonRaces.MRData.RaceTable.Races;

            foreach (var race in seasaonRacesList)
            {
                listSeasonRaces.Add(new SeasonRaceInfoModel
                {
                    Round = race.round,
                    RaceName = race.raceName,
                    CircuitName = race.Circuit.circuitName,
                    Country = race.Circuit.Location.country
                });
            }

            return GetFormattedSeasonRaces(listSeasonRaces);
        }

        private string GetFormattedSeasonRaces(List<SeasonRaceInfoModel> listSeasonRaces)
        {
            StringBuilder formatedText = new StringBuilder();

            foreach (var race in listSeasonRaces)
            {
                formatedText.AppendLine($"{race.Round}. {race.RaceName} on the {race.CircuitName} track in {race.Country}");
            }

            return formatedText.ToString();
        }
    }
}

