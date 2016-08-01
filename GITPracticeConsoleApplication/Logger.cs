﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GITPracticeConsoleApplication
{
    public static class Logger
    {
        public static void Error(string message, string module)
        {
            WriteEntry(message, "Error", module);
        }

        public static void Error(Exception ex, string module)
        {
            WriteEntry(ex.Message, "Error", module);
        }

        public static void Warning(string message, string module)
        {
            WriteEntry(message, "Warning", module);
        }

        public static void Info(string message, string module)
        {
            WriteEntry(message, "Info", module);
        }

        private static void WriteEntry(string message, string type, string module)
        {
            Trace.WriteLine(
                    string.Format("{0} : {1} >>> [{2}] : {3}",
                                  DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                                  type,
                                  module,
                                  message));
        }
    }
}
