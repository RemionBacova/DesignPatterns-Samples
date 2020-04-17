using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singleton_Object_Example.Services
{
    class FileWriter
    {
        private static FileWriter _Instance;
        private static readonly object _Lock = new object();
        private StreamWriter _StreamWriter;

        public static FileWriter Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new FileWriter();
                    }
                }
                return _Instance;
            }
        }

        private FileWriter()
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _StreamWriter = new StreamWriter(Path.Combine(exePath, "MessageFile.txt"), true);
        }

        public void WriteLine(string Msg)
        {
            _StreamWriter.WriteLine(Msg);
            _StreamWriter.Flush();
        }
     
    }
}
