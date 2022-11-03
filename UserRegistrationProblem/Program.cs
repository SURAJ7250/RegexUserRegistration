namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the firstname: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(UserValidation.CheckFirstName(FirstName));

            Console.WriteLine("Enter the lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine(UserValidation.CheckLastName(lastname));

            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();
            Console.WriteLine(UserValidation.checkEmail(email));

            Console.WriteLine("Enter the phonenumber: ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine(UserValidation.checkMobileNumber(phonenumber));

            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
            Console.WriteLine(UserValidation.checkPassword(password));
        }
    }
}