using UserRegistrationProblem;

namespace RegExDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Registration Problem");
            //UC1
            FirstName firstName = new FirstName();
            Console.WriteLine("Please Enter your first name");
            var check = firstName.ValidateFirstName(Console.ReadLine());
            Console.WriteLine(check);
        }
    }
}