using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth.Programming
{
    class PrgmFunction
    {
        private int numberOfArgument;
        private List<string> argumentTypes;
        ProgramManager programManager;

        public PrgmFunction(ProgramManager programManager)
        {
            this.programManager = programManager;
        }

        private Error Eval(List<string> arguments)
        {
            if (arguments.Count != numberOfArgument)
            {
                return Error.NotRightNumberOfParameters(arguments.Count, numberOfArgument);
            }

            throw new System.NotImplementedException();
        }

        public Error Execute(List<string> arguments)
        {
            if(arguments.Count != numberOfArgument)
            {
                return Error.NotRightNumberOfParameters(arguments.Count, numberOfArgument);
            }

            throw new System.NotImplementedException();
        }

    }

    class Error
    {
        string msg;
        bool isError;

        public Error(string msg, bool isError)
        {
            this.msg = msg;
            this.isError = isError;
        }

        public static Error NoError()
        {
            return new Error("", false);
        }

        public static Error NotRightNumberOfParameters(int received, int expected)
        {
            return new Error("Got " + received+", expected "+ expected, false);
        }
    }
}
