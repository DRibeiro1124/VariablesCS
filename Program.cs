using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
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

            //Part 2

            //Practice Getting Input From the User
            //Ask the user for their name and store it in a variable named userName.
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            //Print out a greeting to the user, using their name.
            var greeting = "It is a pleasure to meet you, " + userName + "!";
            Console.WriteLine(greeting);

            //Part 3

            //Practice Getting Different Types of Input From the User

            //Ask the user to input two numbers.
            //Get the numbers as strings using Console.ReadLine, store them in variables named firstNumberAsString and secondNumberAsString
            Console.Write("Can you please tell me your favorite number? ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Thank you! I like number " + firstNumberAsString + " too! What is your second favorite number? ");
            var secondNumberAsString = Console.ReadLine();
            Console.WriteLine("Thanks again! Your two favorite numbers are " + firstNumberAsString + " and " + secondNumberAsString);

            //Part 3
            // Converting String Input Into Numbers
            //Convert each string above to a double using double.Parse. Save the first value in a variable named firstOperand and the second value in a variable named secondOperand.
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            //Part 4
            //Doing Math
            //Add the operand variables from above and save the results in a variable named sum.
            var sum = firstOperand + secondOperand;
            Console.WriteLine(userName + " if I take your two favorite numbers and add them together, the result would be " + sum);

            //Subtract the secondOperand variable from the firstOperand variable and save the results in a variable named difference.
            //I did an experiment where I took 6 and 10 as my two favorite numbers and I was getting -4 so I wrote (help from the wife) a simple if/else to get the difference between the two numbers
            double difference;
            if (secondOperand > firstOperand)
            {
                difference = secondOperand - firstOperand;
            }
            else
            {
                difference = firstOperand - secondOperand;
            }
            Console.WriteLine(userName + " also, I can take your favorite two numbers and get the difference by subtracting them and the result would be " + difference);

            //Multiply the operand variables and save the results in a variable named product.
            var product = firstOperand * secondOperand;
            Console.WriteLine(userName + " we can also take those two favorite numbers and multiply them to get " + product);

            //Divide the firstOperand by the secondOperand and save the results in a variable named quotient.
            var quotient = firstOperand / secondOperand;
            Console.WriteLine("We can also divide those same two numbers and get " + quotient);

            //Find the remainder when one operand is divided by the other and save the results in a variable named remainder. See this page if you need to learn more about the modulo operator.
            var remainder = firstOperand % secondOperand;
            Console.WriteLine("The remainder of those two numbers is " + remainder);

            //ADVENTURE MODE
            //Using Logic
            //Add some logic to your program that prints a different, special, greeting to the user if their name happens to be Alice.
            Console.Write("What is your name? ");
            var newUser = Console.ReadLine();
            var aliceGreeting = " Hello Alice, how about a nice cup of tea?";
            var newGreeting = " Hello " + newUser + " have you seen Alice? I hope she's not in Wonderland ";
            string Alice = "Alice";
            string name = " ";
            if (newUser == Alice)
            {
                newGreeting = aliceGreeting;
            }
            Console.WriteLine(newGreeting);

            //Using DateTime
            //Use the type DateTime to represent the date variables.
            var whatMonth = DateTime.Now
            Console.WriteLine(" Wow " + newUser + " I can't believe it's already " + whatMonth);
            //See the lesson on variables for some guidance on DateTime

        }

    }
}
