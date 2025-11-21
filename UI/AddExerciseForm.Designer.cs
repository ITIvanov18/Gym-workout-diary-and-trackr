namespace Gym_Workout_Diary___Tracker.UI
{
    partial class AddExerciseForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxExerciseType = new System.Windows.Forms.ComboBox();
            this.labelSets = new System.Windows.Forms.Label();
            this.numberOfSets = new System.Windows.Forms.NumericUpDown();
            this.labelReps = new System.Windows.Forms.Label();
            this.numberOfReps = new System.Windows.Forms.NumericUpDown();
            this.labelWeightOrDuration = new System.Windows.Forms.Label();
            this.numWeightOrDuration = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightOrDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(150, 17);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(220, 26);
            this.textName.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(20, 60);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type:";
            // 
            // comboBoxExerciseType
            // 
            this.comboBoxExerciseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExerciseType.FormattingEnabled = true;
            this.comboBoxExerciseType.Items.AddRange(new object[] {
            "Strength",
            "Cardio"});
            this.comboBoxExerciseType.Location = new System.Drawing.Point(150, 57);
            this.comboBoxExerciseType.Name = "comboBoxExerciseType";
            this.comboBoxExerciseType.Size = new System.Drawing.Size(220, 28);
            this.comboBoxExerciseType.TabIndex = 3;
            // 
            // labelSets
            // 
            this.labelSets.AutoSize = true;
            this.labelSets.Location = new System.Drawing.Point(20, 100);
            this.labelSets.Name = "labelSets";
            this.labelSets.Size = new System.Drawing.Size(46, 20);
            this.labelSets.TabIndex = 4;
            this.labelSets.Text = "Sets:";
            // 
            // numberOfSets
            // 
            this.numberOfSets.Location = new System.Drawing.Point(150, 98);
            this.numberOfSets.Name = "numberOfSets";
            this.numberOfSets.Size = new System.Drawing.Size(100, 26);
            this.numberOfSets.TabIndex = 5;
            this.numberOfSets.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelReps
            // 
            this.labelReps.AutoSize = true;
            this.labelReps.Location = new System.Drawing.Point(20, 140);
            this.labelReps.Name = "labelReps";
            this.labelReps.Size = new System.Drawing.Size(51, 20);
            this.labelReps.TabIndex = 6;
            this.labelReps.Text = "Reps:";
            // 
            // numberOfReps
            // 
            this.numberOfReps.Location = new System.Drawing.Point(150, 138);
            this.numberOfReps.Name = "numberOfReps";
            this.numberOfReps.Size = new System.Drawing.Size(100, 26);
            this.numberOfReps.TabIndex = 7;
            this.numberOfReps.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelWeightOrDuration
            // 
            this.labelWeightOrDuration.AutoSize = true;
            this.labelWeightOrDuration.Location = new System.Drawing.Point(20, 180);
            this.labelWeightOrDuration.Name = "labelWeightOrDuration";
            this.labelWeightOrDuration.Size = new System.Drawing.Size(94, 20);
            this.labelWeightOrDuration.TabIndex = 8;
            this.labelWeightOrDuration.Text = "Weight (kg):";
            // 
            // numWeightOrDuration
            // 
            this.numWeightOrDuration.DecimalPlaces = 1;
            this.numWeightOrDuration.Location = new System.Drawing.Point(150, 178);
            this.numWeightOrDuration.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWeightOrDuration.Name = "numWeightOrDuration";
            this.numWeightOrDuration.Size = new System.Drawing.Size(100, 26);
            this.numWeightOrDuration.TabIndex = 9;
            this.numWeightOrDuration.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(150, 230);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 35);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(270, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 35);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddExerciseForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numWeightOrDuration);
            this.Controls.Add(this.labelWeightOrDuration);
            this.Controls.Add(this.numberOfReps);
            this.Controls.Add(this.labelReps);
            this.Controls.Add(this.numberOfSets);
            this.Controls.Add(this.labelSets);
            this.Controls.Add(this.comboBoxExerciseType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Exercise";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightOrDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxExerciseType;
        private System.Windows.Forms.Label labelSets;
        private System.Windows.Forms.NumericUpDown numberOfSets;
        private System.Windows.Forms.Label labelReps;
        private System.Windows.Forms.NumericUpDown numberOfReps;
        private System.Windows.Forms.Label labelWeightOrDuration;
        private System.Windows.Forms.NumericUpDown numWeightOrDuration;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}