using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Müşterini özellikleri tanımlandığı nesnedir - terim açıklama örneği
    public class Customer
    {


        //string Name = string.Empty; //field
        //string Name { get; set; } //property


        public string Name { get; set; }
        public override string ToString()
        {
            return $"ID :{Id} Fullname : {FullName} City {City} ";
        }
        private string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int Id { get; set; }

        private string firstName;

        private string GenderGeneration(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "Mr. ",
                Gender.Female => "Ms. ",
                _ => string.Empty,
            };
        }
        public string FirstName
        {
            get { return GenderGeneration(Gender) + firstName; }
            set { firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
        public Gender Gender { get; set; }


    }

    public enum Gender
    {
        Unclear = 0,
        Male = 1,
        Female = 2
    }
}
