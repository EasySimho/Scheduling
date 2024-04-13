namespace Scheduling
{
    partial class Scheduling
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
            this.AddJobButton = new System.Windows.Forms.Button();
            this.StartProcessButton = new System.Windows.Forms.Button();
            this.ExtensionSelector = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Screen = new System.Windows.Forms.ListBox();
            this.maxTimeSlices = new System.Windows.Forms.TextBox();
            this.ShowMetricsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameInput
            // 
            this.NameInput.BackColor = System.Drawing.SystemColors.Control;
            this.NameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameInput.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(3, 111);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(170, 32);
            this.NameInput.TabIndex = 1;
            this.NameInput.Text = "Name";
            this.NameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameInput.TextChanged += new System.EventHandler(this.textResetName);
            // 
            // TimeInput
            // 
            this.TimeInput.BackColor = System.Drawing.SystemColors.Control;
            this.TimeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeInput.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInput.Location = new System.Drawing.Point(356, 111);
            this.TimeInput.Name = "TimeInput";
            this.TimeInput.Size = new System.Drawing.Size(172, 32);
            this.TimeInput.TabIndex = 3;
            this.TimeInput.Text = "Time";
            this.TimeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeInput.TextChanged += new System.EventHandler(this.textResetTime);
            // 
            // SchedulingSelector
            // 
            this.SchedulingSelector.BackColor = System.Drawing.SystemColors.Control;
            this.SchedulingSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchedulingSelector.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SchedulingSelector.DropDownHeight = 120;
            this.SchedulingSelector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedulingSelector.FormattingEnabled = true;
            this.SchedulingSelector.IntegralHeight = false;
            this.SchedulingSelector.Items.AddRange(new object[] {
            "FCFS",
            "SJF",
            "Round Robin",
            "Limited Round Robin"});
            this.SchedulingSelector.Location = new System.Drawing.Point(3, 107);
            this.SchedulingSelector.Name = "SchedulingSelector";
            this.SchedulingSelector.Size = new System.Drawing.Size(262, 26);
            this.SchedulingSelector.TabIndex = 5;
            this.SchedulingSelector.Text = "Scheduling Mode";
            this.SchedulingSelector.SelectedIndexChanged += new System.EventHandler(this.maxSlicesVisibility);
            // 
            // AddJobButton
            // 
            this.AddJobButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddJobButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddJobButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddJobButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AddJobButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJobButton.Location = new System.Drawing.Point(3, 347);
            this.AddJobButton.Name = "AddJobButton";
            this.AddJobButton.Padding = new System.Windows.Forms.Padding(4);
            this.AddJobButton.Size = new System.Drawing.Size(531, 37);
            this.AddJobButton.TabIndex = 6;
            this.AddJobButton.Text = "Add Job";
            this.AddJobButton.UseVisualStyleBackColor = false;
            this.AddJobButton.Click += new System.EventHandler(this.addJob);
            // 
            // StartProcessButton
            // 
            this.StartProcessButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StartProcessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartProcessButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StartProcessButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartProcessButton.Location = new System.Drawing.Point(3, 245);
            this.StartProcessButton.Name = "StartProcessButton";
            this.StartProcessButton.Size = new System.Drawing.Size(262, 25);
            this.StartProcessButton.TabIndex = 7;
            this.StartProcessButton.Text = "Esegui";
            this.StartProcessButton.UseVisualStyleBackColor = false;
            this.StartProcessButton.Click += new System.EventHandler(this.startProcessing);
            // 
            // ExtensionSelector
            // 
            this.ExtensionSelector.BackColor = System.Drawing.SystemColors.Control;
            this.ExtensionSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtensionSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtensionSelector.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionSelector.FormattingEnabled = true;
            this.ExtensionSelector.Items.AddRange(new object[] {
            ".exe",
            ".msi",
            ".bat",
            ".sys",
            ".dll"});
            this.ExtensionSelector.Location = new System.Drawing.Point(179, 111);
            this.ExtensionSelector.Name = "ExtensionSelector";
            this.ExtensionSelector.Size = new System.Drawing.Size(171, 32);
            this.ExtensionSelector.TabIndex = 9;
            this.ExtensionSelector.Text = "Extension";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.AddJobButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 387);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Add";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.TimeInput, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.ExtensionSelector, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.NameInput, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(531, 325);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBar.Location = new System.Drawing.Point(546, 396);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(610, 35);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 11;
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.SystemColors.Control;
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.FormattingEnabled = true;
            this.Screen.ItemHeight = 17;
            this.Screen.Location = new System.Drawing.Point(546, 3);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(610, 387);
            this.Screen.TabIndex = 12;
            // 
            // maxTimeSlices
            // 
            this.maxTimeSlices.BackColor = System.Drawing.SystemColors.Control;
            this.maxTimeSlices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.maxTimeSlices.Font = new System.Drawing.Font("Arial", 10.75F);
            this.maxTimeSlices.Location = new System.Drawing.Point(271, 109);
            this.maxTimeSlices.MinimumSize = new System.Drawing.Size(4, 26);
            this.maxTimeSlices.Name = "maxTimeSlices";
            this.maxTimeSlices.Size = new System.Drawing.Size(263, 26);
            this.maxTimeSlices.TabIndex = 14;
            this.maxTimeSlices.Text = "Max Slices";
            this.maxTimeSlices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxTimeSlices.Visible = false;
            this.maxTimeSlices.TextChanged += new System.EventHandler(this.SlicesTextClicked);
            // 
            // ShowMetricsButton
            // 
            this.ShowMetricsButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ShowMetricsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowMetricsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShowMetricsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowMetricsButton.Location = new System.Drawing.Point(271, 245);
            this.ShowMetricsButton.Name = "ShowMetricsButton";
            this.ShowMetricsButton.Size = new System.Drawing.Size(263, 25);
            this.ShowMetricsButton.TabIndex = 15;
            this.ShowMetricsButton.Text = "Get Metrics";
            this.ShowMetricsButton.UseVisualStyleBackColor = false;
            this.ShowMetricsButton.Click += new System.EventHandler(this.getMetrics);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.86941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.13059F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Screen, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ProgressBar, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.62069F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.37931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1159, 672);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ShowMetricsButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.StartProcessButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maxTimeSlices, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SchedulingSelector, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 396);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(537, 273);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(300, 5, 300, 5);
            this.label1.Size = new System.Drawing.Size(754, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Scheduling Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1159, 672);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Scheduling";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox TimeInput;
        private System.Windows.Forms.ComboBox SchedulingSelector;
        private System.Windows.Forms.Button AddJobButton;
        private System.Windows.Forms.Button StartProcessButton;
        private System.Windows.Forms.ComboBox ExtensionSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.ListBox Screen;
        private System.Windows.Forms.TextBox maxTimeSlices;
        private System.Windows.Forms.Button ShowMetricsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

