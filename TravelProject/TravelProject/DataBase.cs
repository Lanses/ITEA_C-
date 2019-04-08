using System;
using System.Collections.Generic;
using System.Text;

namespace TravelProject
{
    public class DataBase
    {
        public string[] DepartureCountry = new string[] {"Ukraine",  "Poland", "Germany", "France", "Austria", "Sweeden"};
        public string[] DepartureCity = new string[] {"Kyiv", "Wroclav", "Hamburg", "Paris", "Vienna", "Stockholm" };
        public string[] DestinationCountry = new string[] { "Ukraine", "Poland", "Germany", "France", "Austria", "Sweeden" };
        public string[] DestinationCity = new string[] {"Kyiv", "Wroclav", "Hamburg", "Paris", "Vienna", "Stockholm" };


        public int _price;
        public int _numberOfDays;
        public int _numberOfPersons;
        public DateTime _date;


        

    }
}
