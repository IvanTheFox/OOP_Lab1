using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Lab1.RailwayStation;

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

            NewStationsCountNumeric.Minimum = 1;

            this.MinimumSize = new Size(1000, 600);
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

            LaneTable.Rows.Clear();

            if (stations.Count > 0 && currentIndex >= 0 && currentIndex < stations.Count)
            {
                CurrentStationTextbox.Text = stations[currentIndex].GetName();
                for (int i = 0; i < stations[currentIndex].GetLaneCount(); i++)
                {
                    int trainId = stations[currentIndex].GetTrainOnLane(i);
                    LaneTable.Rows.Add(i, (trainId == -1)? "-" : trainId.ToString());
                }
            }

            else
                CurrentStationTextbox.Text = "";

            // Список всех станций
            StationsListBox.Items.Clear();
            foreach (var station in stations)
            {
                StationsListBox.Items.Add(station.ToString());

            }
        }


        // Переименование текущей станции
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

        // Предыдущая станция
        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (stations.Count == 0) return;

            currentIndex--;
            if (currentIndex < 0)
                currentIndex = stations.Count - 1;

            UpdateUI();
        }

        // Следующая станция
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (stations.Count == 0) return;

            currentIndex++;
            if (currentIndex >= stations.Count)
                currentIndex = 0;

            UpdateUI();
        }

        // Создание новой станции
        private void CreateStationButton_Click(object sender, EventArgs e)
        {
            string name = NewStationTextbox.Text.Trim();
            int laneCount = (int)NewStationsCountNumeric.Value;

            if (laneCount <= 0)
            {
                MessageBox(IntPtr.Zero, "Введенное количество путей не является целым положительным", "Ошибка: Пустой путь", 16);
                return;
            }

            // Если название не задано
            if (string.IsNullOrEmpty(name))
            {
                name = $"Новая станция {stations.Count + 1}";
            }

            RailwayStation newStation = new RailwayStation(name, laneCount);
            stations.Add(newStation);

            // Если это первая станция, она становится текущей
            if (currentIndex == -1)
            {
                currentIndex = 0;
            }

            NewStationTextbox.Clear();
            // Сброс ввода на минимальное допустимое значение
            NewStationsCountNumeric.Value = 1;
            UpdateUI();
        }

        // Очистка пути 
        private void ClearLaneButton_Click(object sender, EventArgs e)
        {
            // Если станция не выбрана
            if (stations.Count == 0 || currentIndex < 0 || currentIndex >= stations.Count)
            {
                MessageBox(IntPtr.Zero, "Нет выбранной станции", "Ошибка: станция не выбрана", 16);
                return;
            }
            try
            {
                stations[currentIndex].DepartFromLane(int.Parse(LaneIDTextbox1.Text));
            }
            catch (FormatException ex)
            {
                MessageBox(IntPtr.Zero, "Введенное значение не является числом", "Ошибка: Некорректный формат числа", 16);
            }
            catch (EmptyLaneException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Пустой путь", 16);
            }
            catch (ArgumentException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Несущесвующий путь", 16);
            }
            UpdateUI();
        }

        // Назначение поезда на путь
        private void AddTrainButton_Click(object sender, EventArgs e)
        {
            // Если станция не выбрана
            if (stations.Count == 0 || currentIndex < 0 || currentIndex >= stations.Count)
            {
                MessageBox(IntPtr.Zero, "Нет выбранной станции", "Ошибка: станция не выбрана", 16);
                return;
            }
            try
            {
                stations[currentIndex].ArriveAtLane(int.Parse(LaneIDTextbox2.Text), int.Parse(TrainIDTextbox.Text));
            }
            catch (FormatException ex)
            {
                MessageBox(IntPtr.Zero, "Введенное значение не является числом", "Ошибка: Некорректный формат числа", 16);
            }
            catch (OccupiedLaneException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Путь занят", 16);
            }
            catch (ArgumentException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Несущесвующий путь", 16);
            }
            UpdateUI();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        [DllImport("user32.dll",CharSet = CharSet.Auto)]
        private static extern IntPtr MessageBox(IntPtr hWnd, string msg, string caption, uint type);

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void ExceptionButton_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 0;
            int result = a / b;
        }
    }
}