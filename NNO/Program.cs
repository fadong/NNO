using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using CommonInterface;

namespace NNO {
    class Program {
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);

        private delegate bool EventHandler(CTLTYPE sig);
        static EventHandler _handler;

        private static SubMain _sm = null;
        private static bool _running = false;

        public enum CTLTYPE {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        static void Main(string[] args) {
            try {
                Console.WriteLine((new SystemInfoScript("NNO Server")));
                _sm = new SubMain();
                Thread t = new Thread(_sm.Run);
                t.Start();
                _running = true;
                while (_running) {
                    string cmd = Console.ReadLine();
                    if (cmd == null || cmd.ToUpper().Equals("EXIT")) {
                        StopProc();
                    }
                }
            } catch (Exception) {
                throw;
            }
        }

        static void StopProc() {


        }
    }
}
