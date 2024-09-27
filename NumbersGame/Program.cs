//SUT24 Johan Hansson

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool correctGuess = false;
            int numberOfGuesses = 0;
            int correct = RandomNumber(); //Method
            int userGuess;

            Console.WriteLine("Jag tänker på ett nummer mellan 1 och 20.\nKan du gissa vilket? Du får fem försök. "); //Greeting

            while (!correctGuess && numberOfGuesses < 5) //While-loop user guess isnt correct and user havent guessed 5 times
            {
                while (!Int32.TryParse(Console.ReadLine(), out userGuess)) //TryParse to catch wrong input
                {
                    Console.WriteLine("Felaktig input, ange ett heltal:");
                } 

                    if (userGuess < correct)        //IF-statement to determine if userGuess is high, low or correct.
                    {
                        Console.WriteLine($"Nära men {userGuess} är för lågt!");
                    }
                    else if (userGuess > correct)
                    {
                        Console.WriteLine($"Tyvärr, {userGuess} är för högt!");
                    }
                    else if (userGuess == correct)
                    {
                        Console.WriteLine("Wohoo! Du gjorde det!");

                    }
                    numberOfGuesses++;              //Counter
                    if (numberOfGuesses == 5)       //IF-statement to detect when user have guessed 5 times. Close program.
                    {
                        Console.WriteLine("Tyvärr du har gissat 5 gånger.");
                        correctGuess = true;
                    }
                
            
            }

        }
        static int RandomNumber() //Random-method to generate a random number
        {
            Random random = new Random();
            int randomNo = random.Next(1, 21);
            return randomNo;
        }
    }
}
