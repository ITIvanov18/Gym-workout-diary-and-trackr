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
    // File: WorkoutEntry.cs
    // Description: Domain model for a single workout diary entry.
    // ------------------------------------------------------------

    /// <summary>
    /// Домейн модел за един запис (entry) в тренировъчния дневник
    /// Описва тренировка в конкретен ден с изброени упражнения и статус
    /// </summary>
    public class WorkoutEntry : Trackable
    {
        public DateTime Date { get; set; }

        public string Title { get; set; }

        public MuscleGroup MuscleGroup { get; set; }

        public WorkoutStatus Status { get; private set; }

        /// <summary>
        /// бележки за тренировка, RPE (rate of perceived exortion), форма и тем подобни
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// списък с упражненията, включени в този тренировъчен запис
        /// </summary>
        public List<Exercise> Exercises { get; private set; }

        /// <summary>
        /// по подразбиране статусът е Planned (планирана тренировка)
        /// </summary>
        /// <param name="date">Датата на тренировката</param>
        /// <param name="title">Кратко заглавие на тренировката</param>
        /// <param name="muscleGroup">Основна мускулна група</param>
        public WorkoutEntry(DateTime date, string title, MuscleGroup muscleGroup)
        {
            Date = date;
            Title = title;
            MuscleGroup = muscleGroup;
            Status = WorkoutStatus.Planned;
            Notes = String.Empty;
            Exercises = new List<Exercise>();
        }

        /// <summary>
        /// метод, който маркира тренировката като завършена
        /// </summary>
        public void MarkCompleted()
        {
            Status = WorkoutStatus.Completed;
        }

        /// <summary>
        /// метод, който връща прогреса за конкретния запис
        /// </summary>
        /// <returns> 0 за планирана тренировка, 1 за завършена </returns>
        public double GetProgress()
        {
            if (Status == WorkoutStatus.Completed)
            {
                return 1.0;
            }

            return 0.0;
        }

        /// <summary>
        /// метод, който изчислява общия тренировъчен обем за всички упражнения в записа (в кг)
        /// </summary>
        public double GetTotalVolume()
        {
            double sum = 0.0;

            foreach (Exercise exercise in Exercises)
            {
                double volume = exercise.GetVolume();
                sum = sum + volume;
            }

            return sum;
        }

        /// <summary>
        /// ToString метод за текстова визуализация на записа
        /// </summary>
        /// <returns> Низ с дата, заглавие и статус </returns>
        public override string ToString()
        {
            string text = Date.ToString("dd.MM.yyyy") + " - " + Title + " [" + Status + "]";
            return text;
        }
    }
}
