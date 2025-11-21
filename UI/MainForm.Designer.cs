namespace Gym_Workout_Diary___Tracker.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.listBoxExercises = new System.Windows.Forms.ListBox();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.buttonRemoveEntry = new System.Windows.Forms.Button();
            this.buttonAddExercise = new System.Windows.Forms.Button();
            this.btnRemoveExercise = new System.Windows.Forms.Button();
            this.buttonMarkCompleted = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelOverallProgress = new System.Windows.Forms.Label();
            this.labelVolumeCaption = new System.Windows.Forms.Label();
            this.labelVolumeValue = new System.Windows.Forms.Label();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEntries
            // 
            this.listBoxEntries.FormattingEnabled = true;
            this.listBoxEntries.ItemHeight = 20;
            this.listBoxEntries.Location = new System.Drawing.Point(10, 12);
            this.listBoxEntries.Name = "listBoxEntries";
            this.listBoxEntries.Size = new System.Drawing.Size(333, 384);
            this.listBoxEntries.TabIndex = 0;
            // 
            // listBoxExercises
            // 
            this.listBoxExercises.FormattingEnabled = true;
            this.listBoxExercises.ItemHeight = 20;
            this.listBoxExercises.Location = new System.Drawing.Point(367, 12);
            this.listBoxExercises.Name = "listBoxExercises";
            this.listBoxExercises.Size = new System.Drawing.Size(450, 384);
            this.listBoxExercises.TabIndex = 1;
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Location = new System.Drawing.Point(10, 430);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(165, 39);
            this.buttonAddEntry.TabIndex = 2;
            this.buttonAddEntry.Text = "Add sample day";
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveEntry
            // 
            this.buttonRemoveEntry.Location = new System.Drawing.Point(195, 430);
            this.buttonRemoveEntry.Name = "buttonRemoveEntry";
            this.buttonRemoveEntry.Size = new System.Drawing.Size(160, 39);
            this.buttonRemoveEntry.TabIndex = 3;
            this.buttonRemoveEntry.Text = "Remove day";
            this.buttonRemoveEntry.UseVisualStyleBackColor = true;
            // 
            // buttonAddExercise
            // 
            this.buttonAddExercise.Location = new System.Drawing.Point(375, 430);
            this.buttonAddExercise.Name = "buttonAddExercise";
            this.buttonAddExercise.Size = new System.Drawing.Size(165, 39);
            this.buttonAddExercise.TabIndex = 4;
            this.buttonAddExercise.Text = "Add exercise";
            this.buttonAddExercise.UseVisualStyleBackColor = true;
            // 
            // btnRemoveExercise
            // 
            this.btnRemoveExercise.Location = new System.Drawing.Point(560, 430);
            this.btnRemoveExercise.Name = "btnRemoveExercise";
            this.btnRemoveExercise.Size = new System.Drawing.Size(165, 39);
            this.btnRemoveExercise.TabIndex = 5;
            this.btnRemoveExercise.Text = "Remove exercise";
            this.btnRemoveExercise.UseVisualStyleBackColor = true;
            // 
            // buttonMarkCompleted
            // 
            this.buttonMarkCompleted.Location = new System.Drawing.Point(745, 430);
            this.buttonMarkCompleted.Name = "buttonMarkCompleted";
            this.buttonMarkCompleted.Size = new System.Drawing.Size(220, 39);
            this.buttonMarkCompleted.TabIndex = 6;
            this.buttonMarkCompleted.Text = "Mark day completed";
            this.buttonMarkCompleted.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 512);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(788, 37);
            this.progressBar1.TabIndex = 7;
            // 
            // labelOverallProgress
            // 
            this.labelOverallProgress.Location = new System.Drawing.Point(806, 521);
            this.labelOverallProgress.Name = "labelOverallProgress";
            this.labelOverallProgress.Size = new System.Drawing.Size(154, 35);
            this.labelOverallProgress.TabIndex = 8;
            this.labelOverallProgress.Text = "Overall progress: 0%";
            this.labelOverallProgress.Click += new System.EventHandler(this.labelOverallProgress_Click);
            // 
            // labelVolumeCaption
            // 
            this.labelVolumeCaption.AutoSize = true;
            this.labelVolumeCaption.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeCaption.Location = new System.Drawing.Point(5, 588);
            this.labelVolumeCaption.Name = "labelVolumeCaption";
            this.labelVolumeCaption.Size = new System.Drawing.Size(234, 27);
            this.labelVolumeCaption.TabIndex = 9;
            this.labelVolumeCaption.Text = "Selected day volume:";
            // 
            // labelVolumeValue
            // 
            this.labelVolumeValue.AutoSize = true;
            this.labelVolumeValue.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeValue.Location = new System.Drawing.Point(255, 588);
            this.labelVolumeValue.Name = "labelVolumeValue";
            this.labelVolumeValue.Size = new System.Drawing.Size(26, 25);
            this.labelVolumeValue.TabIndex = 10;
            this.labelVolumeValue.Text = "0";
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(785, 588);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(180, 39);
            this.buttonCalculateBMI.TabIndex = 11;
            this.buttonCalculateBMI.Text = "Calculate your BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 664);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.labelVolumeValue);
            this.Controls.Add(this.labelVolumeCaption);
            this.Controls.Add(this.labelOverallProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonMarkCompleted);
            this.Controls.Add(this.btnRemoveExercise);
            this.Controls.Add(this.buttonAddExercise);
            this.Controls.Add(this.buttonRemoveEntry);
            this.Controls.Add(this.buttonAddEntry);
            this.Controls.Add(this.listBoxExercises);
            this.Controls.Add(this.listBoxEntries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Gym Workout Diary & Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEntries;
        private System.Windows.Forms.ListBox listBoxExercises;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.Button buttonRemoveEntry;
        private System.Windows.Forms.Button buttonAddExercise;
        private System.Windows.Forms.Button btnRemoveExercise;
        private System.Windows.Forms.Button buttonMarkCompleted;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelOverallProgress;
        private System.Windows.Forms.Label labelVolumeCaption;
        private System.Windows.Forms.Label labelVolumeValue;
        private System.Windows.Forms.Button buttonCalculateBMI;
    }
}