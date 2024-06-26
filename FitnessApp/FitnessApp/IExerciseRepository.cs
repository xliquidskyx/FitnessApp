﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    public interface IExerciseRepository
    {
        Exercise GetExercise(int exerciseId);
        void AddExercise(Exercise exercise);
        void RemoveExercise(string exerciseName);
        List<Exercise> GetAllExercises();

    }
}
