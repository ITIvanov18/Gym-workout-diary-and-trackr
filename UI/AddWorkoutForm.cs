using Gym_Workout_Diary___Tracker.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Workout_Diary___Tracker.UI
{
    public partial class AddWorkoutForm : Form
    {
        // свойства, чрез които MainForm ще вземе данните
        public DateTime SelectedDate { get; private set; }
        public string WorkoutTitle { get; private set; }
        public MuscleGroup SelectedType { get; private set; }

        public AddWorkoutForm()
        {
            InitializeComponent();

            // настройка на ComboBox-а с типовете от Enum-а
            comboBoxType.DataSource = Enum.GetValues(typeof(MuscleGroup));

            // настройка на бутоните за DialogResult
            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
        }

        // този метод се закача за buttonOK Click event-а
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // валидация
            if (string.IsNullOrWhiteSpace(textTitle.Text))
            {
                MessageBox.Show("Моля, въведете заглавие!");
                this.DialogResult = DialogResult.None;
                return;
            }

            // запазване на данните в публичните свойства
            SelectedDate = dtpDate.Value;
            WorkoutTitle = textTitle.Text;
            SelectedType = (MuscleGroup)comboBoxType.SelectedItem;
        }
    }
}
