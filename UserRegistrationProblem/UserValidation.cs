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
        //UC1
        //FirstName the First Letter Should Capital and minimum 3 Character
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        public void ValidationFirstName(string firstname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
        //UC2
        //LastName the First Letter Should Capital and minimum 3 Character
        public const string LASTNAME_REGEX= "^[A-Z]{1}[a-zA-Z]{2}$";
        public void ValidationLastName(string lastname)
        {
            Regex regex = new Regex(LASTNAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
        //UC3
        //E-Mail validation
        public const string EMAIL_REGEX = "^[a-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public void ValidationEmail(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        //UC4
        // Pre define Mobile Format Validation
        public const string MOBILENUMBER_REGEX = "^[0-9]+[\\s]+[0-9]{10}$";
        public void ValidationPhoneNumber(string phonenumber)
        {
            Regex regex = new Regex(MOBILENUMBER_REGEX);
            bool result = regex.IsMatch(phonenumber);
            Console.WriteLine(result);
        }
        //UC5
        public const string PASSWORD_REGEX = "[a-z,A-Z,0-9]{8,}$";
        public void ValidationPassword(string password)
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            bool result = regex.IsMatch(password);
            Console.WriteLine(result);
        }
        //UC6
        //Should  have at least 1 Upper Case
        public const string UPPERCASE_REGEX = "^[A-Z]{1}[a-z]{7}$";
        public void ValidationUppercase(string Uppercase)
        {
            Regex regex = new Regex(UPPERCASE_REGEX);
            bool result = regex.IsMatch(Uppercase);
            Console.WriteLine(result);
        }
    }
}
