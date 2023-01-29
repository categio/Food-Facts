using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    class Food
    {
        //fields to hold banana attributes
        private string _name;
        private string _cals;
        private string _fat;
        private string _carbs;

        public Food(string name, string cals, string fat, string carbs)
        {
            _name = name;
            _cals = cals;
            _fat = fat;
            _carbs = carbs;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Cals
        {
            get { return _cals; }
            set { _cals = value; }
        }

        public string Fat
        {
            get { return _fat; }
            set { _cals = value; }
        }

        public string Carbs
        {
            get { return _carbs; }
            set { _carbs = value; }
        }
    }
}

