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
/*
        var connectionString = "Data Source=training.db";
        var authService = new Authorization(connectionString);*/

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

            }
            else if (input == "2")
            {
                Console.WriteLine("What's your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("What's your e-mail? ");
                string email = Console.ReadLine();
                Console.WriteLine("Set your password: ");
                string password = Console.ReadLine();

                User user = new User();
                user.Register(name, password, email);
                Console.WriteLine(user.Name);
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
