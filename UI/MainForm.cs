using Gym_Workout_Diary___Tracker.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gym_Workout_Diary___Tracker.UI
{
    // ------------------------------------------------------------
    // Student: Ivan Tenev Ivanov
    // Faculty Number: F115436
    // File: MainForm.cs
    // ------------------------------------------------------------

    /// <summary>
    /// UI слой на приложението, който съдържа бизнес логиката и 
    /// event handler-ите, визуалните елементи се описват в Designer файла
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly WorkoutDiary _diary;

        /// <summary>
        /// конструктор, който извиква InitializeComponent (генериран от Designer)
        /// и инициализира домейн обекта
        /// </summary>
        public MainForm()
        {
            // този метод се намира в MainForm.Designer.cs
            // и създава всички визуални елементи
            InitializeComponent();

            labelOverallProgress.AutoSize = true;

            // празен дневник
            _diary = new WorkoutDiary();

            // извиква се event handler-а, когато тренировка е маркирана като завършена
            _diary.WorkoutCompleted += Diary_WorkoutCompleted;

            // изпълнява се метода MainForm_Load при зареждане на формата
            this.Load += MainForm_Load;

            RegisterUiEventHandlers();
        }

        /// <summary>
        /// свързва събитията на контролите (бутони и списъци)
        /// с техните обработчици в този клас
        /// </summary>
        private void RegisterUiEventHandlers()
        {
            // списък с тренировъчни дни
            listBoxEntries.SelectedIndexChanged += ListBoxEntries_SelectedIndexChanged;

            // бутони за дните
            buttonAddEntry.Click += ButtonAddEntry_Click;
            buttonRemoveEntry.Click += ButtonRemoveEntry_Click;
            buttonMarkCompleted.Click += ButtonMarkCompleted_Click;

            // бутони за упражненията
            buttonAddExercise.Click += ButtonAddExercise_Click;
            btnRemoveExercise.Click += ButtonRemoveExercise_Click;

            // статистика
            buttonShowStats.Click += ButtonShowStats_Click;
        }


        /// <summary>
        /// изпълнява се автоматично веднъж, когато формата се зареди
        /// тук по-късно ще добавим примерни записи и ще инициализираме елементите на потребителския интерфейс
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateSampleEntries();
            RefreshEntryList();
            UpdateOverallProgress();
        }

        /// <summary>
        /// методът, който се извиква автоматично, когато WorkoutDiary
        /// съобщи чрез събитието WorkoutCompleted, че даден запис е завършен
        /// </summary>
        private void Diary_WorkoutCompleted(object sender, WorkoutCompletedEventArgs e)
        {
            // засега само излиза log в конзолата
            // в бъдеше може да показва съобщение или да обновява UI
            Console.WriteLine("Workout completed: " + e.CompletedEntry.Title);
        }

        // -------------------- Данни --------------------

        /// <summary>
        /// създават се няколко default тренировъчни дни с упражнения,
        /// за да има какво да се визуализира при стартиране на приложението
        /// </summary>
        private void CreateSampleEntries()
        {
            DateTime today = DateTime.Today;
            // DayOfWeek връща enum (Sunday=0, Monday=1... Friday=5)
            // вадим броя дни, за да се върнем до понеделник
            // в C# неделя е начало на седмицата за Enum-а, но за нас е край)
            int delta = DayOfWeek.Monday - today.DayOfWeek;
            if (delta > 0) delta -= 7; // ако сме неделя, връщаме назад до предишния понеделник

            DateTime mondayDate = today.AddDays(delta);

            // тренировъчен ден 1 - понеделник (сила)
            WorkoutEntry monday = new WorkoutEntry(mondayDate, "Monday - Push", MuscleGroup.Push);
            monday.Exercises.Add(new StrengthExercise("Bench Press", 4, 8, 60));
            monday.Exercises.Add(new StrengthExercise("Shoulder Press", 3, 10, 30));
            _diary.AddEntry(monday);

            // тренировъчен ден 2 - сряда (сила)
            WorkoutEntry wednesday = new WorkoutEntry(mondayDate.AddDays(2), "Wednesday - Legs", MuscleGroup.Legs);
            wednesday.Exercises.Add(new StrengthExercise("Squat", 5, 5, 90));
            wednesday.Exercises.Add(new StrengthExercise("Leg Press", 4, 10, 120));
            _diary.AddEntry(wednesday);

            // тренировъчен ден 3 - петък (сила)
            WorkoutEntry friday = new WorkoutEntry(mondayDate.AddDays(4), "Friday - Pull", MuscleGroup.Pull);
            friday.Exercises.Add(new StrengthExercise("Deadlift", 3, 5, 100));
            friday.Exercises.Add(new StrengthExercise("Barbell Row", 4, 8, 60));
            _diary.AddEntry(friday);

            // тренировъчен ден 4 - неделя (кардио и преса)
            WorkoutEntry sunday = new WorkoutEntry(mondayDate.AddDays(6), "Sunday - Cardio", MuscleGroup.Other);
            sunday.Exercises.Add(new CardioExercise("Treadmill Run", 30));
            sunday.Exercises.Add(new CardioExercise("Rope Jumping", 2, 3));
            _diary.AddEntry(sunday);
        }

        // -------------------- помощни методи за UI --------------------

        /// <summary>
        /// синхронизира UI списъка (`listBoxEntries`) с текущите данни в `_diary`
        /// изчиства старите елементи и презарежда колекцията
        /// </summary>
        private void RefreshEntryList()
        {
            listBoxEntries.Items.Clear();

            foreach (WorkoutEntry entry in _diary.Entries)
            {
                listBoxEntries.Items.Add(entry);
            }
        }

        /// <summary>
        /// обновява списъка с упражнения за избрания ден и калкулира общия обем;
        /// ако не е селектиран ден, нулира стойностите в UI
        /// </summary>
        private void RefreshExerciseList()
        {
            listBoxExercises.Items.Clear();

            WorkoutEntry selectedEntry = GetSelectedEntry();
            if (selectedEntry == null)
            {
                labelVolumeValue.Text = "0";
                return;
            }

            foreach (Exercise exercise in selectedEntry.Exercises)
            {
                listBoxExercises.Items.Add(exercise);
            }

            // изчисляване и визуализация на volume-a
            double volume = selectedEntry.GetTotalVolume();

            // ако е кардио ден (MuscleGroup.Other), показваме "min", иначе "kg"
            string unit = "kg";
            if (selectedEntry.Type == MuscleGroup.Other)
            {
                unit = "min";
            }

            labelVolumeValue.Text = $"{volume:0.##} {unit}";
        }

        /// <summary>
        /// актуализира ProgressBar-а и Label-а спрямо изчисления прогрес от бизнес логиката
        /// скалира стойността от 0.0-1.0 до 0-100%
        /// </summary>
        private void UpdateOverallProgress()
        {
            double progress = _diary.GetProgress(); // 0..1
            int percent = (int)(progress * 100);

            // валидация на границите (clamping)
            if (percent < 0)
            {
                percent = 0;
            }

            if (percent > 100)
            {
                percent = 100;
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = percent;

            labelOverallProgress.Text = "Overall progress: " + percent + "%";
        }

        /// <summary>
        /// helper метод, който връща текущо избрания обект `WorkoutEntry` от ListBox-а
        /// връща null, ако нищо не е селектирано
        /// </summary> 
        private WorkoutEntry GetSelectedEntry()
        {
            WorkoutEntry selectedEntry = listBoxEntries.SelectedItem as WorkoutEntry;
            return selectedEntry;
        }

        // -------------------- Event handlers --------------------

        /// <summary>
        /// обработчик при смяна на избора в списъка с дни
        /// автоматично зарежда упражненията за новоизбрания ден
        /// </summary>
        private void ListBoxEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshExerciseList();
        }

        /// <summary>
        /// създава нов примерен тренировъчен ден (factory logic) и го добавя към дневника
        /// след това обновява UI елементите
        /// </summary>
        private void ButtonAddEntry_Click(object sender, EventArgs e)
        {
            // инстанция на формата
            using (AddWorkoutForm form = new AddWorkoutForm())
            {
                // показва се като диалогов прозорец (блокира главния, докато не се затвори)
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // ако потребителят е натиснал OK, взимаме данните от формата
                    WorkoutEntry newEntry = new WorkoutEntry(
                        form.SelectedDate,
                        form.WorkoutTitle,
                        form.SelectedType
                    );

                    _diary.AddEntry(newEntry);

                    RefreshEntryList();
                    UpdateOverallProgress();
                }
            }
        }

        /// <summary>
        /// изтрива избрания тренировъчен ден след валидация на селекцията
        /// </summary>
        private void ButtonRemoveEntry_Click(object sender, EventArgs e)
        {
            WorkoutEntry selectedEntry = GetSelectedEntry();
            if (selectedEntry == null)
            {
                MessageBox.Show(
                    "Моля, изберете ден, който да изтриете.",
                    "No selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // refresh на всички зависими UI компоненти
            _diary.RemoveEntry(selectedEntry);
            RefreshEntryList();
            RefreshExerciseList();
            UpdateOverallProgress();
        }

        /// <summary>
        /// маркира избрания ден като завършен (completed) и преизчислява общия прогрес
        /// </summary>
        private void ButtonMarkCompleted_Click(object sender, EventArgs e)
        {
            WorkoutEntry selectedEntry = GetSelectedEntry();
            if (selectedEntry == null)
            {
                MessageBox.Show(
                    "Моля, изберете ден, който да маркирате като завършен.",
                    "No selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            _diary.MarkEntryCompleted(selectedEntry);
            RefreshEntryList();
            UpdateOverallProgress();
        }

        /// <summary>
        /// добавя ново упражнение към текущия тренировъчен ден
        /// изисква предварително селектиран ден
        /// </summary>
        private void ButtonAddExercise_Click(object sender, EventArgs e)
        {
            WorkoutEntry selectedEntry = GetSelectedEntry();
            if (selectedEntry == null)
            {
                MessageBox.Show(
                    "Първо изберете тренировъчен ден, към който да добавите упражнение.",
                    "No selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            using (AddExerciseForm form = new AddExerciseForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Взимаме готовото упражнение (Cardio или Strength), което формата е създала
                    Exercise newExercise = form.CreatedExercise;

                    if (newExercise != null)
                    {
                        selectedEntry.Exercises.Add(newExercise);
                        RefreshExerciseList();
                    }
                }
            }

            RefreshExerciseList();
        }

        /// <summary>
        /// трие избраното упражнение от списъка на текущия ден
        /// </summary>
        private void ButtonRemoveExercise_Click(object sender, EventArgs e)
        {
            WorkoutEntry selectedEntry = GetSelectedEntry();
            if (selectedEntry == null)
            {
                return;
            }

            Exercise selectedExercise = listBoxExercises.SelectedItem as Exercise;
            if (selectedExercise == null)
            {
                MessageBox.Show(
                    "Моля, изберете упражнение, което да изтриете.",
                    "No selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            selectedEntry.Exercises.Remove(selectedExercise);
            RefreshExerciseList();
        }

        /// <summary>
        /// генерира и показва обобщена статистика (Total Volume и разпределение по дни) чрез MessageBox
        /// </summary>
        private void ButtonShowStats_Click(object sender, EventArgs e)
        {
            double totalVolume = _diary.GetTotalVolume();
            int[] counts = _diary.GetWorkoutsPerWeekday();

            string message =
                "Total volume in diary: " + totalVolume + Environment.NewLine +
                "Workouts per weekday:" + Environment.NewLine +
                "Mon: " + counts[0] + Environment.NewLine +
                "Tue: " + counts[1] + Environment.NewLine +
                "Wed: " + counts[2] + Environment.NewLine +
                "Thu: " + counts[3] + Environment.NewLine +
                "Fri: " + counts[4] + Environment.NewLine +
                "Sat: " + counts[5] + Environment.NewLine +
                "Sun: " + counts[6];

            MessageBox.Show(message, "Diary statistics",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelOverallProgress_Click(object sender, EventArgs e)
        {

        }
    }
}

