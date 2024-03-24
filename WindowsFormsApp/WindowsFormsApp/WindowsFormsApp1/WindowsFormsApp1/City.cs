using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class City
    {
        //delcare fields
        private string cityName;
        private string cityProvince;
        private int cityPopulation;

        public string CityName
        {
            get { return cityName; } //get method
            set { CityName = value; } //set method

        }
        public string CityProvince
        {
            get { return cityProvince; } //get method
            set { cityProvince = value; } //set method

        }
        public int CityPopulation
        {
            get { return cityPopulation; } //get method
            set { cityPopulation = value; }  //set method


        }




    }
}
