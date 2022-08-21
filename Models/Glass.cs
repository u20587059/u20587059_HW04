using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_4.Models
{
    public class Glass : RecyclableMaterials
    {
        private string _typeOfGlass;

        public Glass(int NumberOfBags, string CollectionDate, string Address, string TypeOfGlass):base(NumberOfBags, CollectionDate, Address)
        {
            _typeOfGlass = TypeOfGlass;
        }

        public string typeOfGlass
        {
            get { return _typeOfGlass; }
            set { _typeOfGlass = value; }
        }

        public override int getPoints()
        {
            int points = 5;
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
            message = "You donated a " + _typeOfGlass + " type of glass";
            return (message);
        }
    }
}