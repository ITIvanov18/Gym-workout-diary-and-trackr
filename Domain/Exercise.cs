using Gym_Workout_Diary___Tracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Workout_Diary___Tracker.Domain
{
    // ------------------------------------------------------------
    // Student: Ivan Tenev Ivanov
    // Faculty Number: F115436
    // File: Exercise.cs
    // ------------------------------------------------------------

    /// <summary>
    /// базов абстрактен клас за всякакъв вид упражнения (например Bench Press, Squat, Deadlift)
    /// демонстрира наследяване и полиморфизъм
    /// </summary>
    public abstract class Exercise
    {
        public string Name { get; set; }

        public Exercise(string name)
        {
            Name = name;
        }

        /// <summary>
        /// абстрактен метод - всеки наследник трябва сам да каже как си смята обема
        /// за силови упражнения е кг * повторения, за кардио е минути
        /// </summary>
        public abstract double GetVolume();

        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// клас за силови упражнения (тежести, повторения, серии)
    /// </summary>
    public class StrengthExercise : Exercise
    {
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        public StrengthExercise(string name, int sets, int reps, double weight)
            : base(name) // Извиква конструктора на базовия клас
        {
            Sets = sets;
            Reps = reps;
            Weight = weight;
        }

        public override double GetVolume()
        {
            return Sets * Reps * Weight;
        }

        public override string ToString()
        {
            return $"{Name} (Strength) - {Sets}x{Reps} @ {Weight}kg";
        }
    }

    /// <summary>
    /// клас за кардио упражнения (продължителност)
    /// може да има серии (напр. 3 рунда скачане на въже) или да е 1 серия (jogging)
    /// </summary>
    public class CardioExercise : Exercise
    {
        public double DurationMinutes { get; set; }
        public int Sets { get; set; }

        // конструктор с опция за серии (default е 1)
        public CardioExercise(string name, double durationMinutes, int sets = 1)
            : base(name)
        {
            DurationMinutes = durationMinutes;
            Sets = sets;
        }

        public override double GetVolume()
        {
            // при кардио обемът обикновено е просто времето (или време * серии)
            return DurationMinutes * Sets;
        }

        public override string ToString()
        {
            if (Sets > 1)
            {
                return $"{Name} (Cardio) - {Sets} sets x {DurationMinutes} min";
            }
            return $"{Name} (Cardio) - {DurationMinutes} min";
        }
    }
}
