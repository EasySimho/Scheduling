namespace Scheduling
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameInput = new System.Windows.Forms.TextBox();
            this.TimeInput = new System.Windows.Forms.TextBox();
            this.SchedulingSelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ExtensionSelector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Screen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxTimeSlices = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(6, 57);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 23);
            this.NameInput.TabIndex = 1;
            this.NameInput.Text = "Name";
            this.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameInput.TextChanged += new System.EventHandler(this.textResetName);
            // 
            // TimeInput
            // 
            this.TimeInput.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInput.Location = new System.Drawing.Point(6, 98);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.Size = new System.Drawing.Size(100, 23);
            this.TimeInput.TabIndex = 3;
            this.TimeInput.Text = "Time";
            this.TimeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeInput.TextChanged += new System.EventHandler(this.textResetTime);
            // 
            // SchedulingSelector
            // 
            this.SchedulingSelector.DropDownHeight = 120;
            this.SchedulingSelector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedulingSelector.FormattingEnabled = true;
            this.SchedulingSelector.IntegralHeight = false;
            this.SchedulingSelector.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "Round Robin",
            "Limited Round Robin"});
            this.SchedulingSelector.Location = new System.Drawing.Point(987, 186);
            this.SchedulingSelector.Name = "SchedulingSelector";
            this.SchedulingSelector.Size = new System.Drawing.Size(160, 26);
            this.SchedulingSelector.TabIndex = 5;
            this.SchedulingSelector.Text = "Scheduling Mode";
            this.SchedulingSelector.SelectedIndexChanged += new System.EventHandler(this.maxSlicesVisibility);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 162);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4);
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Job";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addJob);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(987, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "esegui";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.startProcessing);
            // 
            // ExtensionSelector
            // 
            this.ExtensionSelector.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionSelector.FormattingEnabled = true;
            this.ExtensionSelector.Items.AddRange(new object[] {
            ".exe",
            ".msi",
            ".bat",
            ".sys",
            ".dll"});
            this.ExtensionSelector.Location = new System.Drawing.Point(131, 56);
            this.ExtensionSelector.Name = "ExtensionSelector";
            this.ExtensionSelector.Size = new System.Drawing.Size(81, 24);
            this.ExtensionSelector.TabIndex = 9;
            this.ExtensionSelector.Text = "Extension";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameInput);
            this.groupBox1.Controls.Add(this.ExtensionSelector);
            this.groupBox1.Controls.Add(this.TimeInput);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Add";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 625);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1135, 35);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 11;
            // 
            // Screen
            // 
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Screen.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.FormattingEnabled = true;
            this.Screen.ItemHeight = 17;
            this.Screen.Location = new System.Drawing.Point(12, 258);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(1135, 342);
            this.Screen.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-69, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(600, 5, 600, 5);
            this.label1.Size = new System.Drawing.Size(1354, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scheduling Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxTimeSlices
            // 
            this.maxTimeSlices.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTimeSlices.Location = new System.Drawing.Point(888, 186);
            this.maxTimeSlices.MinimumSize = new System.Drawing.Size(4, 26);
            this.maxTimeSlices.Name = "maxTimeSlices";
            this.maxTimeSlices.Size = new System.Drawing.Size(93, 22);
            this.maxTimeSlices.TabIndex = 14;
            this.maxTimeSlices.Text = "Max Slices";
            this.maxTimeSlices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTimeSlices.Visible = false;
            this.maxTimeSlices.TextChanged += new System.EventHandler(this.SlicesTextClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 672);
            this.Controls.Add(this.maxTimeSlices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SchedulingSelector);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TimeInput;
        private System.Windows.Forms.ComboBox SchedulingSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ExtensionSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ListBox Screen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxTimeSlices;
    }
}

