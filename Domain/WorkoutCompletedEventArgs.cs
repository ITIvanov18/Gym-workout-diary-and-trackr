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
    // File: WorkoutCompletedEventArgs.cs
    // ------------------------------------------------------------

    /// <summary>
    /// специален клас, който описва допълнителната информация,
    /// предавана към event listener-ите на събитието WorkoutDiary.WorkoutCompleted
    /// </summary>
    public class WorkoutCompletedEventArgs : EventArgs
    {
        public WorkoutEntry CompletedEntry { get; private set; }

        /// <summary>
        /// създава нов обект с информация за току-що завършен запис
        /// той след това се подава като втори параметър на event handler-a WorkoutCompleted
        /// </summary>
        
        /// <param name="completedEntry">
        /// записът от дневника, който е завършен (не трябва да е null)
        /// </param>
        public WorkoutCompletedEventArgs(WorkoutEntry completedEntry)
        {
            CompletedEntry = completedEntry;
        }
    }
}
