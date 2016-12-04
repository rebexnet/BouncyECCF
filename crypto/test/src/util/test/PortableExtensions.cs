
#if PORTABLE
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Org.BouncyCastle
{
    static class PortableExtensions
    {
        public static void Close(this Stream stream) => stream.Dispose();
        public static void Close(this TextWriter writer) => writer.Dispose();
    }
}

#endif
