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
    // File: WorkoutStatus.cs
    // ------------------------------------------------------------

    /// <summary>
    /// Enum тип за статус на тренировъчен запис в дневника
    /// </summary>
    public enum WorkoutStatus
    {
        /// <summary>
        /// Тренировката е планирана, но още не е изпълнена
        /// </summary>
        Planned,

        /// <summary>
        /// тренировката е изпълнена и записът е завършен
        /// </summary>
        Completed
    }
}
