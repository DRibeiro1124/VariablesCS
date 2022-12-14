using System;

namespace VariablesCS
{
    static class Program
    {
        static void CupOfCoffee()
        {
            //Part 1
            //Practice creating variables
            //Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day.
            int numberOfCupsOfCoffee = 0;
            //Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
            string fullName = "Becker";
            //Create a variable (use your best judgment for type) called today and set it equal to today's date.
            var todayDate = DateTime.Today;
            //Use Console.WriteLine and your variables, numberOfCupsOfCoffee, fullName, and today, to output all three on one line.
            var phrase = todayDate + " is when I found out that my dog " + fullName + " drinks " + numberOfCupsOfCoffee + " cups of coffee daily, which is good, because he is a dog!!";
            Console.WriteLine(phrase);
        }
        static string NameGreeting()
        {
            //Part 2

            //Practice Getting Input From the User
            //Ask the user for their name and store it in a variable named userName.
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            //Print out a greeting to the user, using their name.
            var greeting = "It is a pleasure to meet you, " + userName + "!";
            Console.WriteLine(greeting);
            return userName;
        }

        static (string, string) FavoriteNumbers()
        {
            //Part 3
            //Practice Getting Different Types of Input From the User
            //Ask the user to input two numbers.
            //Get the numbers as strings using Console.ReadLine, store them in variables named firstNumberAsString and secondNumberAsString
            Console.Write("Can you please tell me your favorite number? ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write($"Thank you! I like number {firstNumberAsString} too! What is your second favorite number? ");
            var secondNumberAsString = Console.ReadLine();
            Console.WriteLine($"Thanks again! Your two favorite numbers are {firstNumberAsString} and {secondNumberAsString}");
            return (firstNumberAsString, secondNumberAsString);
        }

        static void SumOfValues(double firstOperand, double secondOperand, string userName)
        {
            //Add the operand variables from above and save the results in a variable named sum.
            var sum = firstOperand + secondOperand;
            Console.WriteLine($"{userName} if I take your two favorite numbers and add them together, the result would be {sum}");

        }

        static void DifferenceOfValues(double firstOperand, double secondOperand, string userName)
        {
            //Part 5
            //Doing Math

            //Subtract the secondOperand variable from the firstOperand variable and save the results in a variable named difference.
            double difference;
            if (secondOperand > firstOperand)
            {
                difference = secondOperand - firstOperand;
            }
            else
            {
                difference = firstOperand - secondOperand;
            }
            Console.WriteLine($"{userName} also, I can take your favorite two numbers and get the difference by subtracting them and the result would be {difference}");
        }


        static void MultiplicationValue(double firstOperand, double secondOperand, string userName)
        {//Multiply the operand variables and save the results in a variable named product.
            var product = firstOperand * secondOperand;
            Console.WriteLine($"{userName} we can also take those two favorite numbers and multiply them to get {product}");
        }

        static void QuotientValue(double firstOperand, double secondOperand, string userName)
        {
            //Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"We can also divide those same two numbers and get {quotient}");
        }

        static void RemainderValue(double firstOperand, double secondOperand, string userName)
        {
            //Find the remainder when one operand is divided by the other and save the results in a variable named remainder. See this page if you need to learn more about the modulo operator.
            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"The remainder of those two numbers is {remainder}");
        }

        static void SpecialGreeting()
        {
            //ADVENTURE MODE
            //Using Logic
            //Add some logic to your program that prints a different, special, greeting to the user if their name happens to be Alice.
            Console.Write("What is your name? ");
            var newUser = Console.ReadLine();
            var aliceGreeting = " Hello Alice, please be very careful with the Queen of Hearts, she is evil!";
            var newGreeting = " Hello " + newUser + " have you seen Alice? I hope she's not in Wonderland ";
            string alice = "Alice";
            string name = " ";
            if (newUser == alice)
            {
                newGreeting = aliceGreeting;
            }
            Console.WriteLine(newGreeting);

            //Using DateTime
            //Use the type DateTime to represent the date variables.
            var whatMonth = DateTime.Now;
            Console.WriteLine($" Wow {newUser} I can't believe it's already {whatMonth}");
            //See the lesson on variables for some guidance on DateTime

        }

        static void Main(string[] args)
        {
            CupOfCoffee();
            string userName = NameGreeting();
            (string firstNumberAsString, string secondNumberAsString) = FavoriteNumbers();
            //Part 4
            // Converting String Input Into Numbers
            //Convert each string above to a double using double.Parse. Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            SumOfValues(firstOperand, secondOperand, userName);
            DifferenceOfValues(firstOperand, secondOperand, userName);
            MultiplicationValue(firstOperand, secondOperand, userName);
            QuotientValue(firstOperand, secondOperand, userName);
            RemainderValue(firstOperand, secondOperand, userName);
            SpecialGreeting();

        }

    }

}
