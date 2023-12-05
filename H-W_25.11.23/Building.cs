using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_25._11._23
{
    class Building
    {
        private static int _id;

        private int _number;
        private double _height;
        private int _floors;
        private int _apartments;
        private int _entrances;

        public Building()
        {
            _id++;
            _number = _id;
        }

        public int Number
        {
            get { return _number; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Floors
        {
            get { return _floors; }
            set { _floors = value; }
        }

        public int Apartments
        {
            get { return _apartments; }
            set { _apartments = value; }
        }

        public int Entrances
        {
            get { return _entrances; }
            set { _entrances = value; }
        }

        public double FloorHeight()
        {
            if (_floors > 0)
            {
                return _height / _floors;
            }
            else
            {
                return 0;
            }
        }

        public double ApartmentsPerEntrance()
        {
            if (_entrances > 0)
            {
                return (double)_apartments / _entrances;
            }
            else
            {
                return 0;
            }
        }

        public double ApartmentsPerFloor()
        {
            if (_floors > 0)
            {
                return (double)_apartments / _floors;
            }
            else
            {
                return 0;
            }
        }
    }
}
