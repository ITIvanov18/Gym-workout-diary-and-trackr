namespace Gym_Workout_Diary___Tracker.UI
{
    partial class BmiCalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelHeight = new System.Windows.Forms.Label();
            this.valueHeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.valueWeight = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResultIndex = new System.Windows.Forms.Label();
            this.labelResultCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(30, 30);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(95, 20);
            this.labelHeight.TabIndex = 0;
            this.labelHeight.Text = "Height (cm):";
            // 
            // valueHeight
            // 
            this.valueHeight.Location = new System.Drawing.Point(150, 28);
            this.valueHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            this.valueHeight.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            this.valueHeight.Name = "valueHeight";
            this.valueHeight.Size = new System.Drawing.Size(120, 26);
            this.valueHeight.TabIndex = 1;
            this.valueHeight.Value = new decimal(new int[] { 175, 0, 0, 0 });
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(30, 80);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(94, 20);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Weight (kg):";
            // 
            // valueWeight
            // 
            this.valueWeight.DecimalPlaces = 1;
            this.valueWeight.Location = new System.Drawing.Point(150, 78);
            this.valueWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            this.valueWeight.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            this.valueWeight.Name = "valueWeight";
            this.valueWeight.Size = new System.Drawing.Size(120, 26);
            this.valueWeight.TabIndex = 3;
            this.valueWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(34, 130);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(236, 40);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate BMI";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResultIndex
            // 
            this.labelResultIndex.AutoSize = true;
            this.labelResultIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultIndex.Location = new System.Drawing.Point(30, 190);
            this.labelResultIndex.Name = "labelResultIndex";
            this.labelResultIndex.Size = new System.Drawing.Size(89, 29);
            this.labelResultIndex.TabIndex = 5;
            this.labelResultIndex.Text = "BMI: --";
            // 
            // labelResultCategory
            // 
            this.labelResultCategory.AutoSize = true;
            this.labelResultCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultCategory.Location = new System.Drawing.Point(30, 230);
            this.labelResultCategory.Name = "labelResultCategory";
            this.labelResultCategory.Size = new System.Drawing.Size(97, 25);
            this.labelResultCategory.TabIndex = 6;
            this.labelResultCategory.Text = "Category:";
            // 
            // BmiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.labelResultCategory);
            this.Controls.Add(this.labelResultIndex);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.valueWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.valueHeight);
            this.Controls.Add(this.labelHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "BmiForm";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.valueHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.NumericUpDown valueHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.NumericUpDown valueWeight;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResultIndex;
        private System.Windows.Forms.Label labelResultCategory;
    }
}