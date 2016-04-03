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
        private static int charInWordCount;

        public static int FunctionType
        {
            get { return functionType; }
            set { functionType = value; }
        }

        public static int CharInWordCount
        {
            get { return charInWordCount; }
            set { charInWordCount = value; }
        }
    }
}
