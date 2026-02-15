namespace Lab1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StationsCountTextbox = new System.Windows.Forms.TextBox();
            this.CurrentStationTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.StationsListBox = new System.Windows.Forms.ListBox();
            this.CreateStationButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NewStationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewStationsCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LaneIDTextbox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ClearLaneButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TrainIDTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.LaneIDTextbox2 = new System.Windows.Forms.TextBox();
            this.AddTrainButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LaneTable = new System.Windows.Forms.DataGridView();
            this.LaneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NewStationsCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная 1, Бригада 3. Шепелев, Гриднев";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество станций:";
            // 
            // StationsCountTextbox
            // 
            this.StationsCountTextbox.Location = new System.Drawing.Point(219, 64);
            this.StationsCountTextbox.Name = "StationsCountTextbox";
            this.StationsCountTextbox.Size = new System.Drawing.Size(173, 34);
            this.StationsCountTextbox.TabIndex = 2;
            // 
            // CurrentStationTextbox
            // 
            this.CurrentStationTextbox.Location = new System.Drawing.Point(219, 109);
            this.CurrentStationTextbox.Name = "CurrentStationTextbox";
            this.CurrentStationTextbox.Size = new System.Drawing.Size(173, 34);
            this.CurrentStationTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Текущая станция:";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Location = new System.Drawing.Point(23, 155);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(189, 34);
            this.RenameTextBox.TabIndex = 5;
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(231, 154);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(161, 34);
            this.RenameButton.TabIndex = 6;
            this.RenameButton.Text = "Переименовать";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(23, 449);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(225, 36);
            this.PrevButton.TabIndex = 7;
            this.PrevButton.Text = "Предыдущая станция";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(280, 449);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(229, 36);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Следующая станция";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StationsListBox
            // 
            this.StationsListBox.FormattingEnabled = true;
            this.StationsListBox.ItemHeight = 27;
            this.StationsListBox.Location = new System.Drawing.Point(506, 20);
            this.StationsListBox.Name = "StationsListBox";
            this.StationsListBox.Size = new System.Drawing.Size(664, 247);
            this.StationsListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 565);
            this.Controls.Add(this.StationsListBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentStationTextbox);
            this.Controls.Add(this.StationsCountTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StationsCountTextbox;
        private System.Windows.Forms.TextBox CurrentStationTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ListBox StationsListBox;
    }
}

