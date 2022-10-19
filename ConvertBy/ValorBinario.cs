using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBy
{
    public class ValorBinario
    {
        private readonly uint[] _valorBy32bit =
        {   1, 2, 4, 8, 16, 32, 64, 128, 256, 512,
            1024, 2048, 4096, 8192, 16384, 32768, 65536,
            131072,  262144, 524288, 262144, 524288,
            262144, 524288, 4194304, 8388608, 16777216,
            33554432, 67108864, 134217728, 268435456, 536870912,
            1073741824, 2147483648 
        };

        public uint[] ValorBinario32bit
        {
            get { return _valorBy32bit; }
        }
    }
}
