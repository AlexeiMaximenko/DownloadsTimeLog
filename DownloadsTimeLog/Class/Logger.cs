using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadsTimeLog.Class
{
    class Logger
    {
        private string path;

        public Logger(string path)
        {
            this.path = path;
        }

        public void Logging(string logSave)
        {
            var streamwriter = new StreamWriter(path, true, Encoding.UTF8);
            streamwriter.WriteLine(logSave);
            streamwriter.Close();
        }
        public static void Logging(string logSave, string path)
        {
            var streamwriter = new StreamWriter(path, true, Encoding.UTF8);
            streamwriter.WriteLine(logSave);
            streamwriter.Close();
        }
    }
}
