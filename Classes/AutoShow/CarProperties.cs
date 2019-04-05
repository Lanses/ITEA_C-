using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShow
{
    public class CarProperties : AutoShow
    {
        public string Concern;
        public string Model;
        public string Colour;

        public int _price;
        public int _horsePower;
        public int _topSpeed;
        public int _dateOfRelease;

        public CarProperties(string concern, string model, string colour)
        {
            Concern = concern;
            Model = model;
            Colour = colour;
        }

        public CarProperties(int price, int horsePower, int topSpeed, int dateOfRelease)
        {
            _price = price;
            _horsePower = horsePower;
            _topSpeed = topSpeed;
            _dateOfRelease = dateOfRelease;
        }
    }
}
