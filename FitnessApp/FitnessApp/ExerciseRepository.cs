using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public class ExerciseRepository : IExerciseRepository
    {
        private List<Exercise> exercises;
        private int nextExerciseId;
        public ExerciseRepository() 
        { 
            exercises = new List<Exercise>();
            nextExerciseId = 0;
        }

        public void AddExercise(Exercise exercise)
        {
            exercise.ExerciseId = nextExerciseId++;
            exercises.Add(exercise);
        }

        public List<Exercise> GetAllExercises()
        {
            return exercises;
        }

        public Exercise GetExercise(string exerciseName)
        {
            return exercises.FirstOrDefault(e => e.ExerciseName == exerciseName);
        }

        public void RemoveExercise(string exerciseName)
        {
            var exercise = exercises.FirstOrDefault(e => e.ExerciseName == exerciseName);

            if (exercise != null)
            {
                exercises.Remove(exercise);
            }
        }
    }
}
