using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class TimeWatcher : IDisposable
    {
        private readonly Stopwatch _watcher;
        private readonly string _methodname;
        public TimeWatcher(string method_name) {

            _watcher = Stopwatch.StartNew();
            _methodname = method_name;
        }
        
        public void Dispose()
        {
            _watcher.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_methodname} execute time: {_watcher.Elapsed}");
            Console.ResetColor();
        }

    }
}
