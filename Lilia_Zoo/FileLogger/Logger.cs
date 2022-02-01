using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilia_Zoo
{
    class Logger : ILogger
    {
        public Logger(Type type)
        {
            Type = type;

            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }
        }
        private Type Type { get; }

        private string Path = "Logger.txt";
        public void Info(string info)
        {
            string log = $"{this.Type.Name}- Info: {info}, {DateTime.Now}";
            Log(log);
        }
        public void Error(string error)
        {
            string log = $"{this.Type.Name}- Error: {error}, {DateTime.Now}";
            Log(log);
        }
        private void Log(string message)
        {
            File.AppendAllText(Path, message + "\n");
        }
    }
}
