using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JolpiF1Library.Model
{
    public class DriverStandingsModel
    {
        public MRData MRData { get; set; }
    }

    public class MRData
    {
        public string Xmlns { get; set; }
        public string Series { get; set; }
        public string Url { get; set; }
        public string Limit { get; set; }
        public string Offset { get; set; }
        public string Total { get; set; }
        public StandingsTable StandingsTable { get; set; }
    }

    public class StandingsTable
    {
        public string Season { get; set; }
        public string Round { get; set; }
        public List<StandingsList> StandingsLists { get; set; }
    }

    public class StandingsList
    {
        public string Season { get; set; }
        public string Round { get; set; }
        public List<DriverStanding> DriverStandings { get; set; }
    }

    public class DriverStanding
    {
        public string Position { get; set; }
        public string PositionText { get; set; }
        public string Points { get; set; }
        public string Wins { get; set; }
        public Driver Driver { get; set; }
        public List<Constructor> Constructors { get; set; }
    }

    public class Driver
    {
        public string DriverId { get; set; }
        public string PermanentNumber { get; set; }
        public string Code { get; set; }
        public string Url { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string DateOfBirth { get; set; }
        public string Nationality { get; set; }
    }

    public class Constructor
    {
        public string ConstructorId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
    }


}
