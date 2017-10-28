using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Programming
{
    abstract class PrgmClass
    {
        public string Type;
        Dictionary<string,string> fields;

        public Variable this[int key]
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public static Variable operator +(PrgmClass v1, PrgmClass v2)
        {
            if (v1.Type == v2.Type)
            {
                return null;
            }
            return null;
        }

        public static Variable operator -(PrgmClass v1, PrgmClass v2)
        {
            if (v1.Type == v2.Type)
            {
                return null;
            }
            return null;
        }

        public static Variable operator *(PrgmClass v1, PrgmClass v2)
        {
            if (v1.Type == v2.Type)
            {
                return null;
            }
            return null;
        }

        public static Variable operator /(PrgmClass v1, PrgmClass v2)
        {
            if (v1.Type == v2.Type)
            {
                return null;
            }
            return null;
        }
    }
}
