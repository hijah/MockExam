using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace MockEksamen1
{
    public class Owner
    {
        /// <summary>
        /// Properties for the class.
        /// </summary>
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }


        /// <summary>
        /// Constructor for the class that contains the properties.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        public Owner(string address, string name, string phone)
        {
            Address = address;
            Name = name;
            Phone = phone;
        }

        /// <summary>
        /// Method that make sure that the address is more than 6 character long, if not it gives an exception.
        /// </summary>
        /// <returns></returns>
        public string AddressRequirement()
        {
            if (Address.Length < 6 )
            {
                throw new ArgumentException("The address have to be more than 6 characters");
            }
            return Address;
        }
        /// <summary>
        /// Method to insure that name is more than 4 characters long, if not it will give an exception.
        /// </summary>
        /// <returns></returns>
        public string NameRequirement()
        {
            if (Name.Length < 4)
            {
                throw new ArgumentException("Name must have more than 4 characters");
            }
            return Name;
        }
        /// <summary>
        /// Method to make sure that phone is 8 charcters, if not it will throw an exception.
        /// </summary>
        /// <returns></returns>
        public string PhoneRequirement()
        {
            if (Phone.Length != 8)
            {
                throw new ArgumentException("Phone must contain 8 characters");
            }
            return Phone;
        }



    }
}