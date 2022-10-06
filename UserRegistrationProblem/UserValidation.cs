using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        //UC13
        //Use Lambda Expression to validate User Entry
       // List<string> userData = new List<string>();
        public const string USER_FIRST_NAME = "^[A-Z]{1}[a-zA-Z]{2}$";
        public void ValidationFirstName(string firstname)
        {
             bool FirstName(string firstName) => (Regex.IsMatch(firstName, USER_FIRST_NAME));
        }
        public const string USER_LAST_NAME = "^[A-Z]{1}[a-zA-Z]{2}$";
        public void ValidationLastName(string lastname)
        {
             bool LastName(string lastName) => (Regex.IsMatch(lastName, USER_LAST_NAME));
        }
        public const string USEREMAIL_REGEX = "^[a-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public void ValidationEmail(string email)
        {
             bool Email(string email) => (Regex.IsMatch(email, USEREMAIL_REGEX));
        }
        public const string USERPHONENUMBER_REGEX = "^[0-9]+[\\s]+[0-9]{10}$";
        public void ValidationPhoneNumber(string phonenumber)
        {
            bool MobileNumber(string mobileNumb) => (Regex.IsMatch(mobileNumb, USERPHONENUMBER_REGEX));
        }
        public const string USERPASSWORD_REGEX = "[a-z,A-Z,0-9]{8,}$";
        public void ValidationPassword(string password)
        {
            bool Password(string password) => (Regex.IsMatch(password, USERPASSWORD_REGEX));
        }
    }
}
