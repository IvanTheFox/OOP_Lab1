using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Lab1.RailwayStation;

namespace Lab1
{
    public partial class Form1 : Form
    {
        List<RailwayStation> _stations;
        int _currentIndex;

        public Form1()
        {
            InitializeComponent();

            _stations = new List<RailwayStation>();
            _currentIndex = -1;

            // Текстовые поля только для чтения
            StationsCountTextbox.ReadOnly = true;
            CurrentStationTextbox.ReadOnly = true;

            NewStationsCountNumeric.Minimum = 1;

            this.MinimumSize = new Size(1000, 600);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Примеры станций
            _stations.Add(new RailwayStation("Станция 1", 5));
            _stations.Add(new RailwayStation("Станция 2", 3));
            _stations.Add(new RailwayStation("Станция 3", 4));
            _stations.Add(new RailwayStation("Станция 4", 2));

            if (_stations.Count > 0)
                _currentIndex = 0;

            UpdateUI();
        }

        // Обновление всех элементов интерфейса
        private void UpdateUI()
        {
            // Общее количество станций
            StationsCountTextbox.Text = _stations.Count.ToString();

            LaneTable.Rows.Clear();

            if (_stations.Count > 0 && _currentIndex >= 0 && _currentIndex < _stations.Count)
            {
                CurrentStationTextbox.Text = _stations[_currentIndex].GetName();
                for (int i = 0; i < _stations[_currentIndex].GetLaneCount(); i++)
                {
                    int trainId = _stations[_currentIndex].GetTrainOnLane(i);
                    LaneTable.Rows.Add(i, (trainId == -1)? "-" : trainId.ToString());
                }
            }

            else
                CurrentStationTextbox.Text = "";

            // Список всех станций
            StationsListBox.Items.Clear();
            foreach (var station in _stations)
            {
                StationsListBox.Items.Add(station.ToString());

            }
        }

        // Переименование текущей станции
        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (_stations.Count == 0 || _currentIndex < 0 || _currentIndex >= _stations.Count)
                return;

            string newName = RenameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newName))
            {
                _stations[_currentIndex].Rename(newName);
                RenameTextBox.Clear();
                UpdateUI();
            }
        }

        // Предыдущая станция
        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (_stations.Count == 0) return;

            _currentIndex--;
            if (_currentIndex < 0)
                _currentIndex = _stations.Count - 1;

            UpdateUI();
        }

        // Следующая станция
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_stations.Count == 0) return;

            _currentIndex++;
            if (_currentIndex >= _stations.Count)
                _currentIndex = 0;

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
                name = $"Новая станция {_stations.Count + 1}";
            }

            RailwayStation newStation = new RailwayStation(name, laneCount);
            _stations.Add(newStation);

            // Если это первая станция, она становится текущей
            if (_currentIndex == -1)
            {
                _currentIndex = 0;
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
            if (_stations.Count == 0 || _currentIndex < 0 || _currentIndex >= _stations.Count)
            {
                MessageBox(IntPtr.Zero, "Нет выбранной станции", "Ошибка: станция не выбрана", 16);
                return;
            }
            try
            {
                _stations[_currentIndex].DepartFromLane(int.Parse(LaneIDTextbox1.Text));
            }
            catch (FormatException ex)
            {
                MessageBox(IntPtr.Zero, "Введенное значение не является числом", "Ошибка: Некорректный формат числа", 16);
            }
            catch (EmptyLaneException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Пустой путь", 16);
            }
            catch (InvalidLaneIdException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Несущесвующий путь", 16);
            }
            UpdateUI();
        }

        // Назначение поезда на путь
        private void AddTrainButton_Click(object sender, EventArgs e)
        {
            // Если станция не выбрана
            if (_stations.Count == 0 || _currentIndex < 0 || _currentIndex >= _stations.Count)
            {
                MessageBox(IntPtr.Zero, "Нет выбранной станции", "Ошибка: станция не выбрана", 16);
                return;
            }
            try
            {
                _stations[_currentIndex].ArriveAtLane(int.Parse(LaneIDTextbox2.Text), int.Parse(TrainIDTextbox.Text));
            }
            catch (FormatException ex)
            {
                MessageBox(IntPtr.Zero, "Введенное значение не является числом", "Ошибка: Некорректный формат числа", 16);
            }
            catch (OccupiedLaneException ex)
            {
                MessageBox(IntPtr.Zero, ex.Message, "Ошибка: Путь занят", 16);
            }
            catch (InvalidLaneIdException ex)
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
    }
}