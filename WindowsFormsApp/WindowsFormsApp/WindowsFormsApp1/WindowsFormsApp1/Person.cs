using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        //delcare fields
        private string personName;
        private string cityAddress;
        private DateTime cityDateOfBirth;

        public string PersonName
        {
            get { return personName; } //get method
            set { personName = value; } //set method

        }
        public string CityAddress
        {
            get { return cityAddress; } //get method
            set { cityAddress = value; } //set method

        }
        public DateTime CityDateOfBirth
        {
            get { return cityDateOfBirth; } //get method
            set { cityDateOfBirth = value; } //set method 

        }
    }
}
