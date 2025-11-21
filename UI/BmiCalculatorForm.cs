using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Gym_Workout_Diary___Tracker.UI
{
    public partial class BmiCalculatorForm : Form
    {
        public BmiCalculatorForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double height = (double)valueHeight.Value;
            double weight = (double)valueWeight.Value;

            double bmi = Domain.BmiCalculatorService.CalculateBmi(weight, height);
            string category = Domain.BmiCalculatorService.GetCategory(bmi);

            labelResultIndex.Text = $"BMI: {bmi:0.0}";
            labelResultCategory.Text = $"Category: {category}";

            if (bmi < 18.5)
            {
                // поднормено тегло - синьо
                labelResultIndex.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else if (bmi < 25)
            {
                // нормално - зелено
                labelResultIndex.ForeColor = System.Drawing.Color.Green;
            }
            else if (bmi < 30)
            {
                // наднормено - оранжево
                labelResultIndex.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                // Сериозно затлъстяване - червено
                labelResultIndex.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
