using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4netTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Loghelper.ReadLog4netConfig();
            Loghelper.Outputlog();
        }
    }
}
