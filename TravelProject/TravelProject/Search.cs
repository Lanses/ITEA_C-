using System;
using System.Collections.Generic;
using System.Text;

namespace TravelProject
{
    public class Search : DataBase 
    {
        public Search(string departureCountry, string departureCity, string destinationCountry, string destinationCity)
        {
            DepartureCountry = departureCountry;
            DepartureCity = departureCity;
            DestinationCountry = destinationCountry;
            DestinationCity = destinationCity;
        }
    }
}