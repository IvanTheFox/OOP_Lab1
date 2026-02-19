using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class RailwayStation
    {
        static int stationCount = 0;
        const int defaultLaneCount = 4;
        const string defaultName = "Станция без названия";
        string name;
        int laneCount;
        int[] lanes;
        public RailwayStation()
            : this(defaultName, defaultLaneCount)
        { }
        public RailwayStation(int _laneCount)
            : this(defaultName, _laneCount)
        { }
        public RailwayStation(string _name)
            : this(_name, defaultLaneCount)
        { }
        public RailwayStation(string _name, int _laneCount)
        {
            stationCount++;
            name = _name;
            laneCount = _laneCount;

            lanes = new int[laneCount];
            for (int i = 0; i < laneCount; i++)
                lanes[i] = -1;

        }
        public RailwayStation(string _name, int[] _lanes)
        {
            stationCount++;
            name = _name;
            lanes = _lanes;
            laneCount = lanes.Length;
        }
        ~RailwayStation()
        {
            stationCount--;
        }
        public class EmptyLaneException : Exception
        {
            public EmptyLaneException()
                : base("Этот путь уже пуст")
            { }
            public EmptyLaneException(int laneId)
                : base($"Путь <{laneId}> уже пуст")
            { }
            public EmptyLaneException(string msg)
                : base(msg)
            { }
        }
        public class OccupiedLaneException : Exception
        {
            public OccupiedLaneException()
                : base("Этот путь занят")
            { }
            public OccupiedLaneException(int laneId)
                : base($"Путь <{laneId}> занят")
            { }
            public OccupiedLaneException(int laneId, int trainId)
                : base($"Путь <{laneId}> занят поездом <{trainId}>")
            { }
            public OccupiedLaneException(string msg)
                : base(msg)
            { }
        }
        private void CheckLaneId(int laneId)
        {
            if (laneId < 0 || laneId >= laneCount)
                throw new ArgumentException($"Предоставленный id пути за пределами допустимых границ [0, {laneCount - 1}]");
        }
        public bool IsLaneEmpty(int laneId)
        {
            CheckLaneId(laneId);
            return lanes[laneId] == -1;
        }
        public int DepartFromLane(int laneId)
        {
            CheckLaneId(laneId);
            if (IsLaneEmpty(laneId))
                throw new EmptyLaneException(laneId);

            int trainId = lanes[laneId];
            lanes[laneId] = -1;
            return trainId;
        }
        public void ArriveAtLane(int laneId, int trainId)
        {
            CheckLaneId(laneId);
            if (trainId < 0)
                throw new ArgumentException("Id поезда должно быть 0 или больше");
            if (!IsLaneEmpty(laneId))
                throw new OccupiedLaneException(laneId, lanes[laneId]);

            lanes[laneId] = trainId;
        }

        public int GetTrainOnLane(int laneId)
        {
            return lanes[laneId];
        }
        public int GetLaneCount()
        {
            return laneCount;
        }
        public string GetLaneCountBase16()
        {
            return laneCount.ToString("x");
        }
        public void Rename(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return $"Станция \"{name}\"\n  Путей: {laneCount}\n";
        }

        public string GetName()
        {
            return name;
        }
    }
}