using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunComplier
{
    public static class GlobalStore
    {
        private static int functionType;

        public static int FunctionType
        {
            get { return functionType; }
            set { functionType = value; }
        }

        //public static getFunction()
        //{
        //    return 
        //}

    }
}
