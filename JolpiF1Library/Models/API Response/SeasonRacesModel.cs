using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Models.API_Response
{
    class SeasonRacesModel
    {
        public Mrdata MRData { get; set; }
    }


    public class Mrdata
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public Racetable RaceTable { get; set; }
    }

    public class Racetable
    {
        public string season { get; set; }
        public List<Race> Races { get; set; }
    }

    public class Race
    {
        public string season { get; set; }
        public string round { get; set; }
        public string url { get; set; }
        public string raceName { get; set; }
        public Circuit Circuit { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public Firstpractice FirstPractice { get; set; }
        public Secondpractice SecondPractice { get; set; }
        public Thirdpractice ThirdPractice { get; set; }
        public Qualifying Qualifying { get; set; }
        public Sprint Sprint { get; set; }
        public Sprintqualifying SprintQualifying { get; set; }
    }

    public class Circuit
    {
        public string circuitId { get; set; }
        public string url { get; set; }
        public string circuitName { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public string lat { get; set; }
        public string _long { get; set; }
        public string locality { get; set; }
        public string country { get; set; }
    }

    public class Firstpractice
    {
        public string date { get; set; }
        public string time { get; set; }
    }

    public class Secondpractice
    {
        public string date { get; set; }
        public string time { get; set; }
    }

    public class Thirdpractice
    {
        public string date { get; set; }
        public string time { get; set; }
    }

    public class Qualifying
    {
        public string date { get; set; }
        public string time { get; set; }
    }

    public class Sprint
    {
        public string date { get; set; }
        public string time { get; set; }
    }

    public class Sprintqualifying
    {
        public string date { get; set; }
        public string time { get; set; }
    }

}
