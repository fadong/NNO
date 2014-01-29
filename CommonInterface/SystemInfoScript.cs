using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace CommonInterface {
    public class SystemInfoScript {

        public SystemInfoScript(string sysname) {
            this._sysname = sysname;

        }

        public string NetInfo() {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public string SysInfo() {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public string StorageInfo() {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("================================= {0} ==============================\n", _sysname);
            sb.AppendFormat("   Load Time : {0}", DateTime.Now.ToString());
            return sb.ToString();
        }

        string _sysname = string.Empty;
    }
}
