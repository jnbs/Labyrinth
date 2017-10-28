using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Programming
{
    class Variable
    {
        float Fvalue;
        string Svalue;
        PrgmClass Cvalue;
        VarType type;

        #region constructors
        public Variable(float value)
        {
            Fvalue = value;
            type = VarType.Real;
        }

        public Variable(string value)
        {
            Svalue = value;
            type = VarType.String;
        }

        public Variable(PrgmClass value)
        {
            Cvalue = value;
            type = VarType.Class;
        }
        #endregion

        public string getType()
        {
            if (type != VarType.Class)
            {
                return type.ToString();
            }
            return Cvalue.Type;
        }

        public bool sameType(Variable var)
        {
            return getType() == getType();
        }

        #region operators
        public static Variable operator+(Variable v1, Variable v2)
        {
            if(v1.getType() == v2.getType())
            {
                if(v1.getType() == VarType.Real.ToString())
                {
                    return new Variable(v1.Fvalue + v2.Fvalue);
                }
                else if(v1.getType() == VarType.String.ToString())
                {
                    return new Variable(v1.Svalue + v2.Svalue);
                }
                else//Class
                {
                    return v1 + v2;
                }
            }
            return null;
        }

        public static Variable operator -(Variable v1, Variable v2)
        {
            if (v1.getType() == v2.getType())
            {
                if (v1.getType() == VarType.Real.ToString())
                {
                    return new Variable(v1.Fvalue - v2.Fvalue);
                }
                else if (v1.getType() == VarType.String.ToString())
                {
                    return null;
                }
                else//class
                {
                    return v1 - v2;
                }
            }
            return null;
        }

        public static Variable operator *(Variable v1, Variable v2)
        {
            if (v1.getType() == v2.getType())
            {
                if (v1.getType() == VarType.Real.ToString())
                {
                    return new Variable(v1.Fvalue * v2.Fvalue);
                }
                else if (v1.getType() == VarType.String.ToString())
                {
                    return null;
                }
                else//class
                {
                    return v1 * v2;
                }
            }
            return null;
        }

        public static Variable operator /(Variable v1, Variable v2)
        {
            if (v1.getType() == v2.getType())
            {
                if (v1.getType() == VarType.Real.ToString())
                {
                    return new Variable(v1.Fvalue / v2.Fvalue);
                }
                else if (v1.getType() == VarType.String.ToString())
                {
                    return null;
                }
                else//class
                {
                    return v1/v2;
                }
            }
            return null;
        }

        public Variable this[int key]
        {
            get
            {
                if (getType() == VarType.String.ToString())
                {
                    return new Variable(this.Svalue[key]);
                }
                else if (getType() != VarType.Real.ToString())
                {
                    return Cvalue[key];
                }
                return null;
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        #endregion*/
    }

    enum VarType
    {
        Real,
        String,
        Class,
    }
}
