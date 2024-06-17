namespace FitnessApp
{
    public class WorkoutPlan
    {
        public int PlanID { get; set; }
        public string PlanName { get; set; }
        public List<Workout> Workouts { get; set; }
    }
}