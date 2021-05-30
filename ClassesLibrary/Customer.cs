using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation )
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;

        }
        public Customer()
        {

        }

        public override string ToString()
        {
            //return base.ToString(); 
            return string.Format("Customer\n" +
                "CustomerID: {0}\n" +
                "FirstName: {1}\n" +
                "LastName: {2}\n" +
                "ContactInformation:{3}",
                CustomerID, FirstName, LastName, ContactInformation);
        }
    }

}
