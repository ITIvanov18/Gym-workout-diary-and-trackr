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
    // File: WorkoutDiary.cs
    // ------------------------------------------------------------

    /// <summary>
    /// представлява целия тренировъчен дневник, който съдържа множество тренировъчни записи (WorkoutEntry)
    /// </summary>
    public class WorkoutDiary : Trackable
    {
        /// <summary>
        /// списък с всичко записи в дневника
        /// </summary>
        public List<WorkoutEntry> Entries { get; private set; }

        /// <summary>
        /// събитие, което се вдига, когато тренировка бъде маркирана като завършена
        /// </summary>
        public event EventHandler<WorkoutCompletedEventArgs> WorkoutCompleted;

        /// <summary>
        /// създава празен тренировъчен дневник без записи
        /// </summary>
        public WorkoutDiary()
        {
            Entries = new List<WorkoutEntry>();
        }

        /// <summary>
        /// добавя нов запис (тренировка) в дневника
        /// </summary>
        public void AddEntry(WorkoutEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("entry");
            }

            Entries.Add(entry);
        }

        /// <summary>
        /// изтрива селектирания запис от дневника
        /// ако записът не съшествува, нищо не се случва
        /// </summary>
        public void RemoveEntry(WorkoutEntry entry)
        {
            if (entry == null)
            {
                return;
            }

            bool removed = Entries.Remove(entry);
        }

        /// <summary>
        /// маркира подадения запис като завършен и уведомява всички event listeners на събитието
        /// </summary>
        public void MarkEntryCompleted(WorkoutEntry entry)
        {
            if (entry == null)
            {
                return;
            }

            entry.MarkCompleted();

            // ако има event listener за събитието, той бива уведомен, като извикаме event handler-a
            EventHandler<WorkoutCompletedEventArgs> handler = WorkoutCompleted;
            if (handler != null)
            {
                WorkoutCompletedEventArgs eventArgs = new WorkoutCompletedEventArgs(entry);
                handler(this, eventArgs);
            }
        }

        /// <summary>
        /// изчислява общия прогрес на дневника като средна стойност от прогреса на всички записи
        /// </summary>
        /// <returns>
        /// стойност между 0 и 1 (ако няма записи, връща 0)
        /// </returns>
        public double GetProgress()
        {
            if (Entries.Count == 0)
            {
                return 0.0;
            }

            double sum = 0.0;

            foreach (WorkoutEntry entry in Entries)
            {
                double progress = entry.GetProgress();
                sum = sum + progress;
            }

            double average = sum / Entries.Count;
            return average;
        }

        /// <summary>
        /// метод, който връща общия тренировъчен обем за всички записи в дневника
        /// </summary>
        /// <returns> сумата от обема на всички упражнения във всички записи </returns>
        public double GetTotalVolume()
        {
            double sum = 0.0;

            foreach (WorkoutEntry entry in Entries)
            {
                double volume = entry.GetTotalVolume();
                sum = sum + volume;
            }

            return sum;
        }

        /// <summary>
        /// масив, който брои колко тренировки има за всеки ден от седмицата
        /// индекс 0 = Monday, 6 = Sunday
        /// </summary>
        /// <returns> масив с 7 елемента - брой тренировки по дни </returns>
        public int[] GetWorkoutsPerWeekday()
        {
            int[] counts = new int[7];

            foreach (var entry in Entries)
            {
                // взима се деня от седмицата
                DayOfWeek day = entry.Date.DayOfWeek;

                // превръщам Monday(1) в 0, Sunday(0) в 6
                int index;
                if (day == DayOfWeek.Sunday)
                {
                    index = 6;
                }
                else
                {
                    index = (int)day - 1;
                }

                counts[index]++;
            }

            return counts;
        }
    }
}
