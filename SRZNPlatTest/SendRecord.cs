using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRZNPlatTest
{
    public class SendRecord
    {
        public string GUID { get; set; }
        public string BeginTime { get; set; }
        public string CompleteTime { get; set; }

        public string Message { get; set; }
        public int ErrCode { get; set; }
    }
}
