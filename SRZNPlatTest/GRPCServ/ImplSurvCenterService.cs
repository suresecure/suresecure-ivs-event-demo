using Grpc.Core;
using Suresecureivs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRZNPlatTest.GRPCServ
{
    public class ImplSurvCenterService : SurvCenterService.SurvCenterServiceBase
    {

        public event Action<Event> OnNewEvent;

        public event Action<HeartbeatRequest> OnHeartBeat;

        #region 构造函数和初始化部分

        public ImplSurvCenterService()
        {
        }
        #endregion


        /// <summary>
        /// 服务端处理并返回处理结果
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<GeneralReply> ReportEvent(Event request, ServerCallContext context)
        {
            try
            {
                if (OnNewEvent != null)
                    OnNewEvent(request);
            }
            catch (Exception exp)
            {
            }
            return Task.FromResult(new GeneralReply { Message = "success " + request.Guid, ErrorCode = 0 });
        }

        public override Task<GeneralReply> Heartbeat(HeartbeatRequest request, ServerCallContext context)
        {
            try
            {
                if (OnHeartBeat != null)
                {
                    OnHeartBeat(request);
                }
            }
            catch (Exception exp)
            {
            }
            return Task.FromResult(new GeneralReply() { ErrorCode = 0, Message = DateTime.Now.ToString("yyyy:MM:dd:HH:mm:ss") });
        }


    }
}
