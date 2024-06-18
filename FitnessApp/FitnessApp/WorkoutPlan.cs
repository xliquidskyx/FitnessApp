namespace FitnessApp
{
    public class WorkoutPlan
    {
        private static int lastPlanId;
        private int planId;
        private string planName;
        private List<Exercise> exercises;

        public int PlanId
        {
            get
            {
                return this.planId;
            }
            set
            {
                this.planId = value;
            }
        }
        public string PlanName
        {
            get
            {
                return this.planName;
            }
            set
            {
                this.planName = value;
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

        public WorkoutPlan() 
        {
            Exercises = new List<Exercise>();
        }

        public WorkoutPlan(string planName)        {
            this.PlanId = ++lastPlanId;
            this.PlanName = planName;
            this.Exercises = new List<Exercise>();
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }
        public void SaveToDatabase()
        {

        }

        public void RemoveFromDatabase()
        {

        }

        public void AddWorkout() 
        { 
        }

        public void RemoveWorkout()
        {
        }

        public void LoadWorkouts()
        {
        }
    }
}