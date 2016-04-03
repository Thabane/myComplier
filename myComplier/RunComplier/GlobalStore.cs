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
        private static int charIntValue;

        public static int FunctionType
        {
            get { return functionType; }
            set { functionType = value; }
        }

        public static int CharIntValue
        {
            get { return charIntValue; }
            set { charIntValue = value; }
        }
    }
}
