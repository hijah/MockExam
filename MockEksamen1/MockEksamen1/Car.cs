using System;

namespace MockEksamen1
{
    public class Car 
    {
        //private enum color
        //{
        //    Black,
        //    White,
        //    Gray,
        //    Red,
        //    Green,
        //    Blue
        //};

        public Color.color Color { get; set; }

        /// <summary>
        /// Making Properties over the Class Car.
        /// </summary>
        public int Doors { get; set; }
        public string Model { get; set; }
        public string RegistrationNo { get; set; }

        /// <summary>
        /// Constructor for Car (contains the properties).
        /// </summary>
        /// <param name="doors"></param>
        /// <param name="model"></param>
        /// <param name="registrationNo"></param>
        public Car(Color.color color, int doors, string model, string registrationNo)
        {
            Color = color;
            //if (Doors < 5 && Doors > 2)
            //{
            Doors = doors;
            //}
            //else
            //{
            //    throw new ArgumentException("Doors must be between 2 and 5");
            //}

            //if (Model != null)
            //{
                Model = model;
            //}
            //else
            //{
            //    throw new NullReferenceException("The model must not be empty");
            //}

            //if (RegistrationNo.Length == 7)
            //{
                RegistrationNo = registrationNo;
            //}
            //else
            //{
            //    throw new ArgumentException("RegistrationNumber must be 7 characters long");
            //}
            

        }


        /// <summary>
        /// A Method that make sure that doors are between 2 and 5, otherwise it will throw an exception.
        /// </summary>
        /// <returns></returns>
        private int DoorReuirements()
        {
            if (Doors < 5 && Doors > 2)
            {
                return Doors;
            }
            throw new ArgumentException("Doors must be between 2 and 5");
        }
        /// <summary>
        /// Method that make sure model is not null. If model is null it sends back an nullexception.
        /// </summary>
        /// <returns></returns>
        private string ModelRequirements()
        {
            if (Model != null)
            {
                return Model;
            }
            throw new NullReferenceException("The model must not be empty");
        }
        /// <summary>
        /// Method to insure that registrationnumber is 7. If registrationnumber is not 7, it will give an exception.
        /// </summary>
        /// <returns></returns>
        private string RegistrationNoRequirements()
        {
            if (RegistrationNo.Length != 7)
            {
                throw new ArgumentException("RegistrationNumber must be 7 characters long");
            }
            return RegistrationNo;
        }

    }
}