using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShow
{
    class Parking : AutoShow
    {
        AutoShow NumberOfPlaces()
        {
            var freePlaces = new AutoShow();
            freePlaces.places = "150";

            return freePlaces;
        }
    }
}
