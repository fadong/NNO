using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Claims;
using System.Security.Principal;
using System.ServiceModel;
using CommonInterface;
using CommonLib;

namespace NNO {
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Reentrant,
        InstanceContextMode=InstanceContextMode.PerSession,
        IncludeExceptionDetailInFaults=true,
        TransactionAutoCompleteOnSessionClose=true)]
    public class ClientService {

        public IList<Claim> ConnectService(ClientInfo ci) {
            try {
                IList<Claim> claims = new List<Claim>();
                if (OperationContext.Current.ClaimsPrincipal == null) {
                    claims.Add(new Claim(ClaimTypes.Name, ci.UserId));
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                }

                ci.ConnectedTime = DateTime.Now;
                
                
                IClientServiceCallback client = OperationContext.Current.GetCallbackChannel<IClientServiceCallback>();
                OperationContext.Current.Channel.Faulted += Channel_Faulted;
                OperationContext.Current.Channel.Closed += Channel_Closed;

                lock (ClientService.CLIENTS) {
                    if (!CLIENTS.Values.Any(k => k.SessionId == OperationContext.Current.SessionId)) {
                        CLIENTS.Add(client, ci);
                    }
                }
                return claims;
            } catch (Exception er) {
                throw;
            } finally {

            }
        }

        void Channel_Closed(object sender, EventArgs e) {
            
        }

        void Channel_Faulted(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        void UnRegisterCallback(IClientChannel client, bool closedGracefully) {




        }

        public static Dictionary<IClientServiceCallback, ClientInfo> CLIENTS = new Dictionary<IClientServiceCallback, ClientInfo>();
    }
}
