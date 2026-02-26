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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NewStationsCountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная 1, Бригада 3. Шепелев, Гриднев";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество станций:";
            // 
            // StationsCountTextbox
            // 
            this.StationsCountTextbox.Location = new System.Drawing.Point(183, 66);
            this.StationsCountTextbox.Name = "StationsCountTextbox";
            this.StationsCountTextbox.Size = new System.Drawing.Size(158, 30);
            this.StationsCountTextbox.TabIndex = 2;
            // 
            // CurrentStationTextbox
            // 
            this.CurrentStationTextbox.Location = new System.Drawing.Point(183, 106);
            this.CurrentStationTextbox.Name = "CurrentStationTextbox";
            this.CurrentStationTextbox.Size = new System.Drawing.Size(158, 30);
            this.CurrentStationTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Текущая станция:";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Location = new System.Drawing.Point(5, 147);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(172, 30);
            this.RenameTextBox.TabIndex = 5;
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(194, 147);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(146, 30);
            this.RenameButton.TabIndex = 6;
            this.RenameButton.Text = "Переименовать";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(1, 17);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(205, 32);
            this.PrevButton.TabIndex = 7;
            this.PrevButton.Text = "Предыдущая станция";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(222, 17);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(208, 32);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "Следующая станция";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // StationsListBox
            // 
            this.StationsListBox.FormattingEnabled = true;
            this.StationsListBox.ItemHeight = 24;
            this.StationsListBox.Location = new System.Drawing.Point(6, 29);
            this.StationsListBox.Name = "StationsListBox";
            this.StationsListBox.Size = new System.Drawing.Size(582, 220);
            this.StationsListBox.TabIndex = 9;
            // 
            // CreateStationButton
            // 
            this.CreateStationButton.Location = new System.Drawing.Point(356, 63);
            this.CreateStationButton.Name = "CreateStationButton";
            this.CreateStationButton.Size = new System.Drawing.Size(115, 68);
            this.CreateStationButton.TabIndex = 10;
            this.CreateStationButton.Text = "Добавить станцию";
            this.CreateStationButton.UseVisualStyleBackColor = true;
            this.CreateStationButton.Click += new System.EventHandler(this.CreateStationButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Новая станция";
            // 
            // NewStationTextbox
            // 
            this.NewStationTextbox.Location = new System.Drawing.Point(124, 63);
            this.NewStationTextbox.Name = "NewStationTextbox";
            this.NewStationTextbox.Size = new System.Drawing.Size(216, 30);
            this.NewStationTextbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Название";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Количество путей";
            // 
            // NewStationsCountNumeric
            // 
            this.NewStationsCountNumeric.Location = new System.Drawing.Point(193, 106);
            this.NewStationsCountNumeric.Name = "NewStationsCountNumeric";
            this.NewStationsCountNumeric.Size = new System.Drawing.Size(146, 30);
            this.NewStationsCountNumeric.TabIndex = 17;
            this.NewStationsCountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Очистить путь";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Назначить поезд на путь";
            // 
            // LaneIDTextbox1
            // 
            this.LaneIDTextbox1.Location = new System.Drawing.Point(74, 52);
            this.LaneIDTextbox1.Name = "LaneIDTextbox1";
            this.LaneIDTextbox1.Size = new System.Drawing.Size(91, 30);
            this.LaneIDTextbox1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID пути";
            // 
            // ClearLaneButton
            // 
            this.ClearLaneButton.Location = new System.Drawing.Point(171, 51);
            this.ClearLaneButton.Name = "ClearLaneButton";
            this.ClearLaneButton.Size = new System.Drawing.Size(128, 30);
            this.ClearLaneButton.TabIndex = 23;
            this.ClearLaneButton.Text = "Очистить";
            this.ClearLaneButton.UseVisualStyleBackColor = true;
            this.ClearLaneButton.Click += new System.EventHandler(this.ClearLaneButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "ID поезда";
            // 
            // TrainIDTextbox
            // 
            this.TrainIDTextbox.Location = new System.Drawing.Point(97, 116);
            this.TrainIDTextbox.Name = "TrainIDTextbox";
            this.TrainIDTextbox.Size = new System.Drawing.Size(91, 30);
            this.TrainIDTextbox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "ID пути";
            // 
            // LaneIDTextbox2
            // 
            this.LaneIDTextbox2.Location = new System.Drawing.Point(282, 116);
            this.LaneIDTextbox2.Name = "LaneIDTextbox2";
            this.LaneIDTextbox2.Size = new System.Drawing.Size(91, 30);
            this.LaneIDTextbox2.TabIndex = 27;
            // 
            // AddTrainButton
            // 
            this.AddTrainButton.Location = new System.Drawing.Point(379, 113);
            this.AddTrainButton.Name = "AddTrainButton";
            this.AddTrainButton.Size = new System.Drawing.Size(172, 34);
            this.AddTrainButton.TabIndex = 28;
            this.AddTrainButton.Text = "Назначить поезд";
            this.AddTrainButton.UseVisualStyleBackColor = true;
            this.AddTrainButton.Click += new System.EventHandler(this.AddTrainButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(996, 609);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 36);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LaneTable
            // 
            this.LaneTable.AllowUserToAddRows = false;
            this.LaneTable.AllowUserToDeleteRows = false;
            this.LaneTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaneTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaneId,
            this.TrainId});
            this.LaneTable.Location = new System.Drawing.Point(14, 35);
            this.LaneTable.Name = "LaneTable";
            this.LaneTable.ReadOnly = true;
            this.LaneTable.RowHeadersWidth = 51;
            this.LaneTable.RowTemplate.Height = 24;
            this.LaneTable.Size = new System.Drawing.Size(262, 139);
            this.LaneTable.TabIndex = 30;
            // 
            // LaneId
            // 
            this.LaneId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LaneId.HeaderText = "Путь";
            this.LaneId.MinimumWidth = 6;
            this.LaneId.Name = "LaneId";
            this.LaneId.ReadOnly = true;
            this.LaneId.Width = 77;
            // 
            // TrainId
            // 
            this.TrainId.HeaderText = "Поезд";
            this.TrainId.MinimumWidth = 6;
            this.TrainId.Name = "TrainId";
            this.TrainId.ReadOnly = true;
            this.TrainId.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StationsCountTextbox);
            this.groupBox1.Controls.Add(this.CurrentStationTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.RenameTextBox);
            this.groupBox1.Controls.Add(this.RenameButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 185);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.LaneTable);
            this.groupBox2.Location = new System.Drawing.Point(25, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 258);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пути текущей станции";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LaneIDTextbox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.AddTrainButton);
            this.groupBox3.Controls.Add(this.ClearLaneButton);
            this.groupBox3.Controls.Add(this.LaneIDTextbox2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TrainIDTextbox);
            this.groupBox3.Location = new System.Drawing.Point(25, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 248);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операции с путями";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.StationsListBox);
            this.groupBox4.Location = new System.Drawing.Point(492, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(619, 257);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Все станции";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.CreateStationButton);
            this.groupBox5.Controls.Add(this.NewStationTextbox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.NewStationsCountNumeric);
            this.groupBox5.Location = new System.Drawing.Point(634, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(477, 158);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Создание станции";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.PrevButton);
            this.groupBox6.Controls.Add(this.NextButton);
            this.groupBox6.Location = new System.Drawing.Point(25, 608);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(445, 57);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 671);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Вокзал";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewStationsCountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.Button CreateStationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewStationTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NewStationsCountNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox LaneIDTextbox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ClearLaneButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TrainIDTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LaneIDTextbox2;
        private System.Windows.Forms.Button AddTrainButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView LaneTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

