using System.Transactions;

namespace FitnessApp
{
    public class Exercise
    {
        private int excerciseId;
        private string excerciseName;
        private int repetitions;
        private int sets;
        private double weight;
        private TimeSpan duration;
        public int ExcerciseId
        {
            get
            {
                return this.excerciseId;
            }
            set
            {
                this.excerciseId = value;
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
        public int Repetitions
        {
            get
            {
                return this.repetitions;
            }
            set
            {
                this.repetitions = value;
            }
        }
        public int Sets
        {
            get
            {
                return this.sets;
            }
            set
            {
                this.sets = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
    }
}