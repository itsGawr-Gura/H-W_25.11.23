using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_25._11._23
{
    class Buildings
    {

        private Building[] _buildings = new Building[10];

        public Building this[int index]
        {
            get { return _buildings[index]; }
            set { _buildings[index] = value; }
        }

    }
}
