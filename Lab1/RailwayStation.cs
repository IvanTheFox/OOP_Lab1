using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class RailwayStation
    {
        static int s_stationCount = 0;
        const int DEFAULT_LANE_COUNT = 4;
        const string DEFAULT_NAME = "Станция без названия";
        string _name;
        int _laneCount;
        int[] _lanes;
        public RailwayStation()
            : this(DEFAULT_NAME, DEFAULT_LANE_COUNT)
        { }
        public RailwayStation(int _laneCount)
            : this(DEFAULT_NAME, _laneCount)
        { }
        public RailwayStation(string _name)
            : this(_name, DEFAULT_LANE_COUNT)
        { }
        public RailwayStation(string _name, int _laneCount)
        {
            s_stationCount++;
            this._name = _name;
            this._laneCount = _laneCount;

            _lanes = new int[this._laneCount];
            for (int i = 0; i < this._laneCount; i++)
                _lanes[i] = -1;

        }
        public RailwayStation(string _name, int[] _lanes)
        {
            s_stationCount++;
            this._name = _name;
            this._lanes = _lanes;
            _laneCount = this._lanes.Length;
        }
        ~RailwayStation()
        {
            s_stationCount--;
        }
        public class EmptyLaneException : DivideByZeroException
        {
            int _laneId;
            public EmptyLaneException()
                : base("Этот путь уже пуст")
            {
                this._laneId = -1;
            }
            public EmptyLaneException(int laneId)
                : base($"Путь <{laneId}> уже пуст")
            {
                this._laneId = laneId;
            }
            public EmptyLaneException(string msg)
                : base(msg)
            {
                this._laneId = -1;
            }
        }
        public class OccupiedLaneException : DivideByZeroException
        {
            int _laneId;
            int _trainId;
            public OccupiedLaneException()
                : base("Этот путь занят")
            {
                _laneId = -1;
                _trainId = -1;
            }
            public OccupiedLaneException(int laneId)
                : base($"Путь <{laneId}> занят")
            {
                this._laneId = laneId;
                this._trainId = -1;
            }
            public OccupiedLaneException(int laneId, int trainId)
                : base($"Путь <{laneId}> занят поездом <{trainId}>")
            {
                this._laneId = laneId;
                this._trainId = trainId;
            }
            public OccupiedLaneException(string msg)
                : base(msg)
            {
                this._laneId = -1;
                this._trainId = -1;
            }
        }
        public class InvalidLaneIdException : DivideByZeroException
        {
            public InvalidLaneIdException()
            : base($"Предоставленный id пути за пределами допустимых границ")
            { }
        }
        public class InvalidTrainIdException : DivideByZeroException
        {
            int _trainId;
            public InvalidTrainIdException(int trainId)
                : base($"Идентификатор поезда <{trainId}> некорректный")
            { }
        }
        public class EmptyNameException : DivideByZeroException
        {
            public EmptyNameException()
                : base($"Станцию нельзя назвать пустым именем")
            { }
        }
        private void CheckLaneId(int laneId)
        {
            if (laneId < 0 || laneId >= _laneCount)
                throw new InvalidLaneIdException();
        }
        public bool IsLaneEmpty(int laneId)
        {
            CheckLaneId(laneId);
            return _lanes[laneId] == -1;
        }
        public int DepartFromLane(int laneId)
        {
            CheckLaneId(laneId);
            if (IsLaneEmpty(laneId))
                throw new EmptyLaneException(laneId);

            int trainId = _lanes[laneId];
            _lanes[laneId] = -1;
            return trainId;
        }
        public void ArriveAtLane(int laneId, int trainId)
        {
            CheckLaneId(laneId);
            if (trainId < 0)
                throw new InvalidTrainIdException(trainId);
            if (!IsLaneEmpty(laneId))
                throw new OccupiedLaneException(laneId, _lanes[laneId]);

            _lanes[laneId] = trainId;
        }

        public int GetTrainOnLane(int laneId)
        {
            CheckLaneId(laneId);
            if (IsLaneEmpty(laneId))
                throw new EmptyLaneException(laneId);
            return _lanes[laneId];
        }
        public int GetLaneCount()
        {
            return _laneCount;
        }
        public string GetLaneCountBase16()
        {
            return _laneCount.ToString("x");
        }
        public void Rename(string newName)
        {
            if (newName == "")
                throw new EmptyNameException();
            _name = newName;
        }
        public override string ToString()
        {
            return $"Станция \"{_name}\"\n  Путей: {_laneCount}\n";
        }

        public string GetName()
        {
            return _name;
        }
    }
}