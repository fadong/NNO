using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using CommonInterface;
using CommonLib;

namespace MCaches {
    /// <summary>
    /// Memory Caching Class
    /// </summary>
    public class OraDBConn {
        /// <summary>
        /// OraDBConn Constructor
        /// </summary>
        private OraDBConn() {
            this._conn = new OracleConnection(MasterConfig.CONNSTR);
            this._conn.Open();
        }

        /// <summary>
        /// OraDBConn Static Instance 반환자
        /// </summary>
        public static OraDBConn BE {
            get { return _instance; }
        }

        private static OraDBConn _instance = new OraDBConn();
        private readonly OracleConnection _conn = null;
    }
}
