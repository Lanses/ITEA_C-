using System;
using System.Collections.Generic;
using System.Text;

namespace TravelProject
{
    public class DataBase
    {
        public string[] DepartureCountry = new string[]
        {
            "Ukraine",  "Poland", "Germany", "France", "Austria", "Sweeden"
        };
        public string[] DepartureCity = new string[]
        {
            "Kyiv", "Wroclav", "Hamburg", "Paris", "Vienna", "Stockholm"
        };
        public string[] DestinationCountry = new string[]
        {
            "Ukraine", "Poland", "Germany", "France", "Austria", "Sweeden"
        };
        public string[] DestinationCity = new string[]
        {
            "Kyiv", "Wroclav", "Hamburg", "Paris", "Vienna", "Stockholm"
        };



        public int _numberOfDays { get; set; }
        public int _numberOfPersons { get; set; }
        public DateTime _date { get; set; }


        public void Price()
        {

        }

    }
}
