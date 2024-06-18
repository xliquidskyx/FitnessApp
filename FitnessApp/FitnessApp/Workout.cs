namespace FitnessApp
{
    public class Workout
    {
        private static int workoutId;
        private List<Exercise> exercises;
    
        public List<Exercise> Exercises 
        {
            get
            {
                return this.exercises;
            }
            set
            {
                this.exercises = value;
            }
        }

        public Workout()
        {
            Exercises = new List<Exercise>();
        }

        public void SaveToDatabase()
        {

        }

        public void RemoveFromDatabase()
        {

        }


    }
}