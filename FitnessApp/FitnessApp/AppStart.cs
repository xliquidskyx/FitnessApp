using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp;
using FitnessApp.Enumerations;

class AppStart
{
    public static void Main(string[] args)
    {

        var authService = new Authorization();

        var exerciseRepository = new ExerciseRepository();

        exerciseRepository.AddExercise(new Exercise("Squat", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength));
        exerciseRepository.AddExercise(new Exercise("sTRET", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength));
        exerciseRepository.AddExercise(new Exercise("Squat", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength));

        while (true)
        {
            Console.WriteLine("Welcome to our fitness app! Do you want to log in or register?");
            Console.WriteLine("1 - Log in");
            Console.WriteLine("2 - Register");
            Console.WriteLine("3 - Exit");
            Console.Write("Select a number: ");
            var input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("What's your email?");
                string email = Console.ReadLine();
                Console.WriteLine("What's your password?");
                string password = Console.ReadLine();

                var user = authService.Login(email, password);

                if(user != null)
                {
                    Console.WriteLine($"Welcome back {user.Name}!");
                }
                else
                {
                    Console.WriteLine("Wrong login information. Try again");
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("What's your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("What's your e-mail? ");
                string email = Console.ReadLine();
                Console.WriteLine("Set your password: ");
                string password = Console.ReadLine();

                if (authService.Register(name, password, email))
                {
                    Console.WriteLine("Registration successful");
                }
                else
                {
                    Console.WriteLine("Email is already taken");
                }
            }
            else if (input == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please pick number from 1 to 3.");
            }
        }



    }
}
