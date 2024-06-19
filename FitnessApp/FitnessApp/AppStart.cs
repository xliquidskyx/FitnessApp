using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FitnessApp;
using FitnessApp.Enumerations;

class AppStart
{
    public static void Main(string[] args)
    {
        //TODO: dodac wiecej cwiczen (wygenerowac w czacie)
        //TODO: zakonczyc funkcjonalnosc aplikacji i finito
        var authService = new Authorization();

        var exerciseRepository = new ExerciseRepository();

        exerciseRepository.AddExercise(new Exercise("Squat", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("sTRET", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Squat", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength, Difficulty.Medium));

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

                if (user != null)
                {
                    Console.WriteLine($"Welcome back {user.Name}!");

                    if (user.HasWorkoutPlan())
                    {
                        Console.WriteLine("You already have a workout plan. Here it is:");
                    } else
                    {
                        Console.WriteLine("You don't have any workout plan, let's create one!");
                        CreateWorkoutPlan(user, exerciseRepository);
                    }
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

    private static void CreateWorkoutPlan(User user, ExerciseRepository repository) {
        {
            Console.WriteLine("What is your fitness level?");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.Write("Select an option: ");
            var option = Console.ReadLine();

            Difficulty selectedDifficulty;
            switch (option)
            {
                case "1":
                    selectedDifficulty = Difficulty.Easy;
                    break;
                case "2":
                    selectedDifficulty = Difficulty.Medium;
                    break;
                case "3":
                    selectedDifficulty = Difficulty.Hard;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            var exercises = repository.GetExercisesByDifficulty(selectedDifficulty);

            if (exercises.Count == 0)
            {
                Console.WriteLine("There are no exercises available for that level. Try with a different option");
                return;
            }

            Console.Write("Choose a name for your plan: ");
            string planName = Console.ReadLine();

            var workoutPlan = new WorkoutPlan(planName, repository);
            foreach(var exercise in exercises)
            {
                workoutPlan.AddExerciseById(exercise.ExerciseId);
            }

            user.AddWorkoutPlan(workoutPlan);
            Console.WriteLine($"Training plan {planName} has been created with {exercises.Count} exercises.");
            workoutPlan.PrintExercises(); //TODO: make it work
        }
    }
}
