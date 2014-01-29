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

        #region "public IList<Claim> ConnectService(ClientInfo ci)"
        /// <summary>
        /// Client Service 접속함수
        /// CreateTime : 2014-01-29
        /// Created By : JaeKyoon, Lee
        /// </summary>
        /// <param name="ci">Client Information</param>
        /// <returns>Claim List</returns>
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
            } catch (Exception) {
                throw;
            } finally {

            }
        }
        #endregion

        #region "void Channel_Closed(object sender, EventArgs e)"
        /// <summary>
        /// Channel Closed 상태 EventHandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        void Channel_Closed(object sender, EventArgs e) {
            
        }
        #endregion

        #region "void Channel_Faulted(object sender, EventArgs e)"
        /// <summary>
        /// Channel Fault 상태 EventHandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event Argument</param>
        void Channel_Faulted(object sender, EventArgs e) {
            
        }
        #endregion

        #region "void UnRegisterCallback(IClientChannel client, bool closedGracefully)"
        /// <summary>
        /// Client Disconnetion
        /// </summary>
        /// <param name="client"></param>
        /// <param name="closedGracefully"></param>
        void UnRegisterCallback(IClientChannel client, bool closedGracefully) {
            try {

            } catch (Exception) {
                throw;
            }
        }
        #endregion

        public static Dictionary<IClientServiceCallback, ClientInfo> CLIENTS = new Dictionary<IClientServiceCallback, ClientInfo>();
    }
}