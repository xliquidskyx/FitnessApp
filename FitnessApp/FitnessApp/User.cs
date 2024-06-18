using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class User
    {
        private static int lastId;
        private int id;
        private string name = "";
        private string password = "";
        private string email = "";
        private List<WorkoutPlan> workoutPlans;

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Password  
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public List<WorkoutPlan> WorkoutPlans
        {
            get
            {
                return this.workoutPlans;
            }
            set
            {
                this.workoutPlans = value;
            }
        }

        public User()
        {
            this.Id = lastId++;
            WorkoutPlans = new List<WorkoutPlan>();
        }

        public User(string name, string password, string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
        }

        public void Login()
        {

        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); //konwertujemy hasło na tablicę bajtów
                var builder = new StringBuilder();

                //konwertujemy bajty na szesnastkowy ciąg znaków
                foreach (var b in bytes) {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void CreateWorkoutPlan(WorkoutPlan newPlan)
        {
            WorkoutPlans.Add(newPlan);
        }

        public void RemoveWorkoutPlan()
        {

        }
        
        public void GetWorkoutPlan()
        {

        }
    }
}
