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
        public static string firstname;
        //UC13
        //Use Lambda Expression to validate User FirstName
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        public void ValidationFirstName(string firstname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
        public static Func<string, string> CheckFirstName = (firstname) =>
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            if (regex.IsMatch(firstname))
            {
                return "Firstname is valid";
            }
            else
            {
                return "Firstname is invalid";
            }
        };
        //Use Lambda Expression to validate User LastName
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        public void ValidationLastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
        public static Func<string, string> CheckLastName = (lastname) =>
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            if (regex.IsMatch(lastname))
            {
                return "lastname is valid";
            }
            else
            {
                return "lastname is invalid";
            }
        };
        //Use Lambda Expression to validate User Email
        public const string EMAIL_REGEX = "^[a-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public void ValidationEmail(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public static Func<string, string> checkEmail = (email) =>
        {
            Regex regex = new Regex(EMAIL_REGEX);
            if (regex.IsMatch(email))
            {
                return "email is valid";
            }
            else
            {
                return "email is invalid";
            }
        };
        //Use Lambda Expression to validate User MobileNumber
        public const string MOBILENUMBER_REGEX = "^[0-9]+[-]+[0-9]{10}$";
        public void ValidationPhoneNumber(string phonenumber)
        {
            Regex regex = new Regex(MOBILENUMBER_REGEX);
            bool result = regex.IsMatch(phonenumber);
            Console.WriteLine(result);
        }
        public static Func<string, string> checkMobileNumber = (phonenumber) =>
        {
            Regex regex = new Regex(MOBILENUMBER_REGEX);
            if (regex.IsMatch(phonenumber))
            {
                return "phonenumber is valid";
            }
            else
            {
                return "phonenumber is invalid";
            }
        };
        //Use Lambda Expression to validate User Password
        public const string PASSWORD_REGEX = "[a-z,A-Z,0-9]{8,}$";
        public void ValidationPassword(string password)
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            bool result = regex.IsMatch(password);
            Console.WriteLine(result);
        }
        public static Func<string, string> checkPassword = (password) =>
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            if (regex.IsMatch(password))
            {
                return "password is valid";
            }
            else
            {
                return "password is invalid";
            }
        };
    }
}
