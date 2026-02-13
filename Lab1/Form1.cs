using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private List<RailwayStation> stations;
        private int currentIndex;

        public Form1()
        {
            InitializeComponent();

            stations = new List<RailwayStation>();
            currentIndex = -1;

            // Текстовые поля только для чтения
            StationsCountTextbox.ReadOnly = true;
            CurrentStationTextbox.ReadOnly = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Примеры станций
            stations.Add(new RailwayStation("Станция 1", 5));
            stations.Add(new RailwayStation("Станция 2", 3));
            stations.Add(new RailwayStation("Станция 3", 4));
            stations.Add(new RailwayStation("Станция 4", 2));

            if (stations.Count > 0)
                currentIndex = 0;

            UpdateUI();
        }

        // Обновление всех элементов интерфейса
        private void UpdateUI()
        {
            // Общее количество станций
            StationsCountTextbox.Text = stations.Count.ToString();

            if (stations.Count > 0 && currentIndex >= 0 && currentIndex < stations.Count)
                CurrentStationTextbox.Text = stations[currentIndex].GetName();
            else
                CurrentStationTextbox.Text = "";

            // Список всех станций
            StationsListBox.Items.Clear();
            foreach (var station in stations)
            {
                StationsListBox.Items.Add(station.ToString());
            }
        }


        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (stations.Count == 0 || currentIndex < 0 || currentIndex >= stations.Count)
                return;

            string newName = RenameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newName))
            {
                stations[currentIndex].Rename(newName);
                RenameTextBox.Clear();
                UpdateUI();
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (stations.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0)
                currentIndex = stations.Count - 1;

            UpdateUI();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (stations.Count == 0) return;

            currentIndex++;
            if (currentIndex >= stations.Count)
                currentIndex = 0;

            UpdateUI();
        }
    }
}