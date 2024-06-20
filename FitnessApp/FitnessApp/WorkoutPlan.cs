using FitnessApp.Enumerations;

namespace FitnessApp
{
    public class WorkoutPlan
    {
        private static int lastPlanId;
        private int planId;
        private string planName;
        private List<Exercise> exercises;
        private ExerciseRepository exercisesRepository;

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

        public WorkoutPlan(string planName, ExerciseRepository exerciseRepository)        {
            this.PlanId = ++lastPlanId;
            this.PlanName = planName;
            this.Exercises = new List<Exercise>();
            this.exercisesRepository = exerciseRepository;
        }
        
        public void AddExerciseById(int exerciseId)
        {
            var exercise = exercisesRepository.GetExercise(exerciseId);
            if(exercise != null)
            {
                Exercises.Add(exercise);
            }
        }

        public void PrintExercises()
        {
            foreach (var exercise in Exercises)
            {
                Console.WriteLine($"- {exercise.ExerciseName} - {exercise.Description}");
            }
        }
    }
}