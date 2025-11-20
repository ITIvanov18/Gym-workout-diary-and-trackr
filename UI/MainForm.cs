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
    /// UI слой на приложението, който съдържа бизнес и обработчиците 
    /// на събития, а визуалните елементи се описват в Designer файла
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

            // празен дневник
            _diary = new WorkoutDiary();

            // извиква се event handler-а, когато тренировка е маркирана като завършена
            _diary.WorkoutCompleted += Diary_WorkoutCompleted;

            // изпълнява се метода MainForm_Load при зареждане на формата
            this.Load += MainForm_Load;
        }

        /// <summary>
        /// изпълнява се автоматично веднъж, когато формата се зареди
        /// тук по-късно ще добавим примерни записи и ще инициализираме елементите на потребителския интерфейс
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: методите
            // CreateSampleEntries();
            // RefreshEntryList();
            // UpdateOverallProgress();
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

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

