using Gym_Workout_Diary___Tracker.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gym_Workout_Diary___Tracker.UI
{
    public partial class AddExerciseForm : Form
    {
        // готовият обект, който ще върнем на MainForm
        public Exercise CreatedExercise { get; private set; }

        public AddExerciseForm()
        {
            InitializeComponent();

            comboBoxExerciseType.SelectedIndex = 0;
            comboBoxExerciseType.SelectedIndexChanged += comboBoxExerciseType_SelectedIndexChanged;

            buttonOK.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            UpdateUI();
        }

        private void comboBoxExerciseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            string type = comboBoxExerciseType.Text;

            if (type == "Cardio")
            {
                // при кардио ползваме полето за тежест като поле за минути
                labelWeightOrDuration.Text = "Duration (min):";

                // СКРИВА полетата за reps, защото при кардио няма такива
                labelReps.Visible = false;
                numberOfReps.Visible = false;
            }
            else // Strength
            {
                labelWeightOrDuration.Text = "Weight (kg):";

                // ПОКАЗВА отново полетата, ако потребителят е върнал на "Strength"
                labelReps.Visible = true;
                numberOfReps.Visible = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            int sets = (int)numberOfSets.Value;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Въведете име на упражнението!");
                this.DialogResult = DialogResult.None;
                return;
            }

            if (comboBoxExerciseType.Text == "Strength")
            {
                int reps = (int)numberOfReps.Value;
                double weight = (double)numWeightOrDuration.Value;
                CreatedExercise = new StrengthExercise(name, sets, reps, weight);
            }
            else // Cardio
            {
                // при CardoExercise конструкторът е (name, duration, sets)
                double duration = (double)numWeightOrDuration.Value;
                CreatedExercise = new CardioExercise(name, duration, sets);
            }
        }
    }
}
