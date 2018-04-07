using System;

namespace NumberGuesser // => this is the container for classes and Methods 
{
    class Program // => this is a class to use Objects. Here we can add 
    {
        // Entry point Method
        static void Main(string[] args) // => Static = no instance of class. 
        {

            StartApp();
            Greeting();
           
            while (true)
            {

                //GENERATE A RANDON NUMBER
                Random random = new Random();
                int rdn = random.Next(1, 11);

                //Init correct number
                int correctNumber = rdn;
                // Init guess var
                int guess = 0;

                //ASK USER FOR A NUMBER
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {

                    //GET USER INPUT
                    string input = Console.ReadLine(); //=> this will be a string input.

                    // SAFETY 
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Plese enter a valid number!");
                        Console.ResetColor();
                        continue;
                    }

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again");
                        if (guess > 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter a number between 1 and 10!!");
                        }
                    }

                    //CAST INPUT TO AN INT
                    guess = int.Parse(input);

                    // TO RESET TEXT COLOR
                    Console.ResetColor();

                }

                //CHANGE COLOR MESSAGE
                Console.ForegroundColor = ConsoleColor.Yellow;

                // SUCCSESS MESSAGE
                Console.WriteLine("Congratulations {0} is the right number!", guess);
                Console.ReadLine();
                //RESET TEXT COLOR
                Console.ResetColor();

                //ASK USER TO PLAY AGAIN 
                Console.WriteLine("Wold you like to play again?? [Y / N]");

                // GETE ANSWER
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {

                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
               


            }
            
        }

        // START APP METHOD();
        static void StartApp()
        {
            //set app vars
            string appName = "Number Gesser";
            string appValue = "1.0.0";
            string appAuthor = "Alejandro Biancucci";
                 // TO CHANGE THE TEXT COLOR
            Console.ForegroundColor = ConsoleColor.Blue;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appValue, appAuthor);

            // TO RESET TEXT COLOR
            Console.ResetColor();
            
        }

        //GREETING METHOD
        static void Greeting()
        {
            // ASK USERS NAME
            Console.WriteLine("What is your name?");

            //Get users input
            string inputName = Console.ReadLine();
            string appAuthor = "Alejandro Biancucci";
            Console.WriteLine("Hello {0}, let's play a game... Made by {1}", inputName, appAuthor);
        }

    }
}
