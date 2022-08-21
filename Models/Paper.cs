using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homework_4.Models
{
    public class Paper:RecyclableMaterials
    {
        private string _grade;
        private string _grain;

        public Paper(int NumberOfBags, string CollectionDate, string Address, string Grade, string Grain ):base(NumberOfBags,CollectionDate, Address)
        {
            _grade = Grade;
            _grain = Grain;
        }

        public string grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string grain
        {
            get { return _grain; }
            set { _grain = value; }
        }
        public override int getPoints()
        {
            int points = 3;
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
            message="You donated paper with a "+_grade+" grade and "+_grain+" grain";
            return message;
        }
    }
}