using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_4.Models
{
    public abstract class RecyclableMaterials
    {
        private int _numberOfBags;
        private string _collectionDate;
        private string _address;

        public RecyclableMaterials (int NumberOfBags, string CollectionDate, string Address )
        {
            _numberOfBags = NumberOfBags;
            _collectionDate = CollectionDate;
            _address = Address;
        }
        public int numberOfBags
        {
            get { return _numberOfBags; }
            set { _numberOfBags = value; }
        }

        public string collectionDate
        {
            get { return _collectionDate; }
            set { _collectionDate = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public virtual int getPoints()
        {

            int points = 0;
            int noPoints = 0;
            if (points > 0)
            {
                noPoints = _numberOfBags * points;
            }
            return noPoints;
        }

        public abstract string MaterialInfo();
    }
}