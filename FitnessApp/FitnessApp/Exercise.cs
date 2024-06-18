using System.Transactions;
using FitnessApp.Enumerations;

namespace FitnessApp
{
    public class Exercise
    {
        private static int lastExcerciseId;
        private int exerciseId;
        private string excerciseName;
        private string description;
        private ExerciseType ExerciseType;
        public int ExcerciseId
        {
            get
            {
                return this.exerciseId;
            }
            set
            {
                this.exerciseId = value;
            }
        }
        public string ExerciseName
        {
            get
            {
                return this.excerciseName;
            }
            set
            {
                this.excerciseName = value;
            }
        }
        public string Description
        {
            get 
            { 
                return this.description;
            }
            set 
            { 
                this.description = value;
            }
        }
        public Exercise(string exerciseName, string description, ExerciseType type)
        {
            this.ExcerciseId = ++lastExcerciseId;
            this.ExerciseName = exerciseName;
            this.Description = description;
            this.ExerciseType = type;
        }
    }
}