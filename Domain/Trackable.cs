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
    // Project: Gym Workout Diary & Tracker
    // File: Trackable.cs
    // ------------------------------------------------------------

    /// <summary>
    /// Интерфейс за обекти, които имат прогрес в някаква форма
    /// Използва се за тренировъчни записи и целия дневник
    /// </summary>
    public interface Trackable
    {
        /// <summary>
        /// Връща текущия прогрес като стойност между 0 и 1
        /// (0 означава 0%, a 1 означава 100% завършеност)
        /// </summary>
        double GetProgress();
    }
}
