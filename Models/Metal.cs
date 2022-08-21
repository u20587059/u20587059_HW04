using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_4.Models
{
    public class Metal:RecyclableMaterials
    {
        private string _typeOfMetal;

        public Metal(int NumberOfBags, string CollectionDate, string Address, string TypeOfMetal):base(NumberOfBags, CollectionDate, Address)
        {
            _typeOfMetal = TypeOfMetal;
        }

        public string typeOfMetal
        {
            get { return _typeOfMetal; }
            set { _typeOfMetal = value; }

        }

        public override int getPoints()
        {
            int points = 7;
            int noPoints = 0;
            if (points > 0)
            {
                noPoints = numberOfBags * points;
            }
            return noPoints;
        }

        public override string MaterialInfo()
        {
            string message = "";
            message = "You donated a " + _typeOfMetal + " type of metal";
            return (message);
        }
    }
}