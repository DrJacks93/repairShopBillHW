namespace repairShopBillHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;

            double num2 = 25.25;

            string firstName = "Derek";

            bool bool1 = false;

            char char2 = 'A';

            int num3 = 7, num4 = 9, num5 = 88;

            const string connString = "Business Name";

            double a, b, c;
            double subtotal;

            string inputString;

            Console.WriteLine("Welcome to the repair Shop");


            Console.WriteLine("Please enter the total for oil change");
            inputString = Console.ReadLine();


            a = Convert.ToDouble(inputString);

            Console.WriteLine("please enter the total for tires");
            inputString = Console.ReadLine();

            b = Convert.ToDouble(inputString);

            Console.WriteLine("please enter your total for inspection");
            inputString = Console.ReadLine();

            c = Convert.ToDouble(inputString);

            subtotal = (a + b + c);

            Console.WriteLine("your total is {0} {1}", subtotal.ToString("C"), "!");

            Console.WriteLine("Your tax is 6%");

            subtotal = (a + b + c) + 0.90;

            subtotal.ToString("C");

           
            Console.WriteLine("Your subtotal is {0} {1}", subtotal.ToString("C"), "!");

            Console.ReadKey();

        }
    }
}
