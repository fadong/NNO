using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterface;

namespace NNO {
    public class SubMain {

        public void Run() {
            this._service = new ClientService();
            this._service.OpenClientServiceHost();
            CLogger.LogTrace("Log Trade");
        }

        ClientService _service = null;
    }
}
