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
    /// модел на едно конкретно упражнение в тренировката
    /// например Bench Press, Squat, Deadlift и тн
    /// </summary>
    public class Exercise
    {
        public string Name { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }

        /// <summary>
        /// създава ново упражнение с име, брой серии, повторения и тежест
        /// </summary>
        public Exercise(string name, int sets, int reps, double weight)
        {
            Name = name;
            Sets = sets;
            Reps = reps;
            Weight = weight;
        }

        /// <summary>
        /// метод, който изчислява тренировъчния обем за това упражнение: sets * reps * weight
        /// </summary>
        /// <returns>Общия обем като число от тип double</returns>
        public double GetVolume()
        {
            double volume = Sets * Reps * Weight;
            return volume;
        }

        /// <summary>
        /// ToString метод за преобразуване на резултата в текстов вид
        /// използва се при показване на обекта в списъци в UI (примерно ListBox)
        /// </summary>
        /// <returns> 
        /// низ във формата: "име - (серии)x(повторения) @ (тежест)kg" 
        /// пример: "Bench Press - 4x8 @ 60kg"
        /// </returns>
        public override string ToString()
        {
            string description = Name + " - " + Sets + "x" + Reps + " @ " + Weight + "kg";
            return description;
        }
    }
}
