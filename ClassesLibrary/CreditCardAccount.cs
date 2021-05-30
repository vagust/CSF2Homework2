using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
   public class CreditCardAccount
    {
        public int AccountNumber { get; set; }
        public Customer ContactInformation { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        public CreditCardAccount(int accountNumber, Customer contactInformation, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            ContactInformation = contactInformation;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }
        public CreditCardAccount()
        {

        }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("CreditCardAccount: \n" +
                "AccountNumber: {0}\n" +
                "ContactInformation: {1}\n" +
                "Balance: {2:c}\n" +
                "IsPastDue: {3}\n" +
                "AnnualInterestRate: {4}\n",
                AccountNumber, ContactInformation, Balance, IsPastDue, AnnualInterestRate);
        }
    }//end Class
}//end Namespace
