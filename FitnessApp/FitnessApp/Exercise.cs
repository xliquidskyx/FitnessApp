namespace FitnessApp
{
    public class Exercise
    {
        public int ExcerciseId { get; set; }
        public int ExerciseName { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set;}
        public double Weight { get; set; }
        public TimeSpan WeightTime { get; set; }
    }
}