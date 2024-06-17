using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class User
    {
        private static int id;
        private string name;
        private string password;
        private string email;
        private List<WorkoutPlan> workoutPlans;
        public int Id
        {
            get
            {
                return this.id;
            }
            set 
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

            WorkoutPlans = new List<WorkoutPlan>();
        }

        public void Register(string name, string password, string email)
        {
            Id = id++;
            Name = this.name;
            Password = this.password;
            Email = this.email;
        }

        public void Login()
        {

        }

        public void AddWorkoutPlan()
        {

        }

        public void RemoveWorkoutPlan()
        {

        }
        
        public void GetWorkoutPlan()
        {

        }
    }
}
