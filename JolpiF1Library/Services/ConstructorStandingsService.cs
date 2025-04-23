using JolpiF1Library.Models;
using JolpiF1Library.Services.Interfaces;
using System.Text;

namespace JolpiF1Library.Services
{
    class ConstructorStandingsService : IApiService
    {
        ConstructorStandingsModel currentConstructorStandings;

        private string _endpoint = "constructorstandings";
        public async Task GetData(HttpClient ApiClient)
        {
            using (HttpResponseMessage response = await ApiClient.GetAsync(_endpoint))
            {
                if (response.IsSuccessStatusCode)
                {
                    currentConstructorStandings = await response.Content.ReadAsAsync<ConstructorStandingsModel>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public string ProcessResponse()
        {
            List<ConstructorInfoModel> listConstructorInfo = new List<ConstructorInfoModel>();
            var constructorStandingList = currentConstructorStandings.MRData.StandingsTable.StandingsLists[0].ConstructorStandings;
            foreach (var standing in constructorStandingList)
            {
                listConstructorInfo.Add(new ConstructorInfoModel
                {
                    Position = standing.position,
                    Name = standing.Constructor.name,
                    Points = standing.points
                });
            }

            return GetFormattedConstructorStanding(listConstructorInfo);
        }

        private string GetFormattedConstructorStanding(List<ConstructorInfoModel> listConstructorInfo)
        {
            StringBuilder formatedText = new StringBuilder();

            foreach (var constructorInfo in listConstructorInfo)
            {
                formatedText.AppendLine($"{constructorInfo.Position}. {constructorInfo.Name} Points: {constructorInfo.Points}");
            }

            return formatedText.ToString();
        }
    }
}
