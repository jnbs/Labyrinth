using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Programming
{
    class Variable<T>
    {
        T value;
        Guid type;

        public Variable(T value)
        {
            this.value = value;
            type = value.GetType().GUID;

        }

        public Guid getType()
        {
            return type;
        }

        public bool sameType(Variable<T> var)
        {
            return getType() == getType();
        }


    }

    enum VarType
    {
        Real,
        String,
        Class,
    }
}
