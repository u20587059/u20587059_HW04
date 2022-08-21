using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_4.Models
{
    public class Plastic:RecyclableMaterials
    {
        private string _polymerType;

        public Plastic(int NumberOfBags, string CollectionDate, string Address, string PolymerType): base(NumberOfBags, CollectionDate, Address)
        {
            _polymerType = PolymerType;
        }

        public string polymerType
        {
            get { return _polymerType; }
            set { _polymerType = value; }
        }

        public override int getPoints()
        {
            int points = 4;
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
            message = "You donated a plastic of polymer type " + _polymerType;
            return message;
        }
    }
}