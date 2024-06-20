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
        //TODO: zakonczyc funkcjonalnosc aplikacji i finito
        var authService = new Authorization();

        var exerciseRepository = new ExerciseRepository();

        exerciseRepository.AddExercise(new Exercise("Squat", "An exercise that targets lower body, primarily the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Push-up", "An exercise that targets the upper body, primarily the chest, shoulders, and triceps.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Burpee", "A full-body exercise that combines a squat, jump, and push-up, targeting various muscle groups and improving cardiovascular fitness.", ExerciseType.Cardio, Difficulty.Hard));
        exerciseRepository.AddExercise(new Exercise("Plank", "An isometric exercise that strengthens the core, including the abdominals, lower back, and shoulders.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Jumping jacks", "A cardio exercise that involves jumping to a position with the legs spread wide and the hands touching overhead, then returning to the starting position.", ExerciseType.Cardio, Difficulty.Easy));
        exerciseRepository.AddExercise(new Exercise("Forward bend", "A flexibility exercise that stretches the hamstrings, calves, and lower back.", ExerciseType.Flexibility, Difficulty.Easy));
        exerciseRepository.AddExercise(new Exercise("Lungs", "An exercise that targets the lower body, including the quadriceps, hamstrings, glutes, and calves.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Bicycle crunches", "An exercise that targets the abdominal muscles, including the obliques.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Mountain climbers", "A cardio exercise that involves running in place from a plank position, engaging the core, arms, and legs.", ExerciseType.Cardio, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Yoga Sun Salutation", "A series of poses that improve flexibility and strength, targeting various muscle groups and joints", ExerciseType.Flexibility, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("High knees", "A cardio exercise that involves running in place while lifting the knees high towards the chest.", ExerciseType.Cardio, Difficulty.Easy));
        exerciseRepository.AddExercise(new Exercise("Deadlift", "An exercise that targets the lower back, glutes, hamstrings, and core.", ExerciseType.Strength, Difficulty.Hard));
        exerciseRepository.AddExercise(new Exercise("Tricep Dips", "An exercise that targets the triceps, shoulders, and chest.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Shoulder stretch", "A flexibility exercise that stretches the shoulders and upper back.", ExerciseType.Flexibility, Difficulty.Easy));
        exerciseRepository.AddExercise(new Exercise("Box jumps", "A plyometric exercise that involves jumping onto and off a box, targeting the legs and improving explosive power.", ExerciseType.Other, Difficulty.Hard));
        exerciseRepository.AddExercise(new Exercise("Calf raises", "An exercise that targets the calf muscles.", ExerciseType.Strength, Difficulty.Easy));
        exerciseRepository.AddExercise(new Exercise("Arm raises", "A flexibility and mobility exercise that involves rotating the arms to improve shoulder flexibility and strength.", ExerciseType.Flexibility, Difficulty.Easy));
        exerciseRepository.AddExercise(new Exercise("Pull-ups", "An upper body exercise that targets the back, shoulders, and arms.", ExerciseType.Strength, Difficulty.Hard));
        exerciseRepository.AddExercise(new Exercise("Side lunges", "An exercise that targets the inner and outer thighs, as well as the glutes.", ExerciseType.Strength, Difficulty.Medium));
        exerciseRepository.AddExercise(new Exercise("Seated forward bend", "A flexibility exercise that stretches the hamstrings and lower back.", ExerciseType.Flexibility, Difficulty.Easy));


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
                    LoggedInMenu(user, exerciseRepository);     
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

    private static void LoggedInMenu(User user, ExerciseRepository repository)
    {
        while (true)
        {
            if (user.HasWorkoutPlan())
            {
                Console.WriteLine("You already have a workout plan(s). Here it is:");
                user.PrintWorkoutPlan();
            }
            else
            {
                Console.WriteLine("You don't have any workout plan, let's create one!");
                CreateWorkoutPlan(user, repository);
            }

            Console.WriteLine("What do you want to do next?");
            Console.WriteLine("1 - Create new plan");
            Console.WriteLine("2 - Exit");
            var userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CreateWorkoutPlan(user, repository);
            }
            else if (userChoice == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please select 1 or 2.");
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
            workoutPlan.PrintExercises();
        }
    }
}
