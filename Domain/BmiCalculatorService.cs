using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Workout_Diary___Tracker.Domain
{
    /// <summary>
    /// помощен клас за изчисляване на Body Mass Index (BMI)
    /// </summary>
    internal class BmiCalculatorService
    {
        /// <summary>
        /// формула: тегло (кг) / (ръст (м) * ръст (м))
        /// </summary>
        public static double CalculateBmi(double weightKg, double heightCm)
        {
            if (heightCm <= 0) return 0;

            double heightMeters = heightCm / 100.0;
            return weightKg / (heightMeters * heightMeters);
        }

        /// <summary>
        /// връща категория спрямо индекса
        /// </summary>
        public static string GetCategory(double bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25) return "Normal";
            if (bmi < 30) return "Overweight";
            return "Obese";
        }
    }
}
