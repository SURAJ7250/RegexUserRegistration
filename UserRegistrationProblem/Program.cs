namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //User FirstName
            Console.WriteLine("Enter the firstname: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(UserValidation.CheckFirstName(FirstName));
            //User LastName
            Console.WriteLine("Enter the lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine(UserValidation.CheckLastName(lastname));
            //User Email
            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();
            Console.WriteLine(UserValidation.checkEmail(email));
            //User PhoneNumber
            Console.WriteLine("Enter the phonenumber: ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine(UserValidation.checkMobileNumber(phonenumber));
            //User Password
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            Console.WriteLine(UserValidation.checkPassword(password));
        }
    }
}