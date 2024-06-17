namespace FitnessApp
{
    public class Workout
    {
        private static int workoutId;
        private List<Exercise> exercises;
        public int WorkoutId
        {
            get
            {
                return this.workoutId;
            }
            set
            {
                this.workoutId = value;
            }
        }
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


    }
}