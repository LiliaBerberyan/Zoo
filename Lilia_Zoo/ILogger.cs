using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilia_Zoo
{
    interface ILogger
    {
        void Info(string info);
        void Error(string error);
    }
}
