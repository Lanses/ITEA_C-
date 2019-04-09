using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Aviary
    {
        private Animal _animal;
        private Herb _herb;

        public void PlaceAnimal(Animal animal)
        {
            _animal = animal;
        }

        public bool IsClean { get; private set; }
        public void PlaceHerb(Herb herb)
        {
            _herb = herb;
        }

        public string GetStatus()
        {


            if(_animal != null && _herb != null)
            {
                return "Animal and herb";
            }

            if (_animal != null)
            {
                return "Animal is inside";
            }

            if(_herb != null)
            {
                return "Herbal is here";
            }

            return "Empty";
        }
    }
}
