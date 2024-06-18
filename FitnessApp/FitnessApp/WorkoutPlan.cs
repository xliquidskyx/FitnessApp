namespace FitnessApp
{
    public class WorkoutPlan
    {
        private static int planId;
        private string planName;
        private List<Workout> workouts;
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
        public List<Workout> Workouts
        {
            get
            {
                return this.workouts;
            }
            set
            {
                this.workouts = value;
            }
        }

        public WorkoutPlan() 
        {
            Workouts = new List<Workout>();
        }

        public WorkoutPlan(string planName, List<Workout> workouts)        {
            planId++;
            this.PlanName = planName;
            Workouts = new List<Workout>();
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