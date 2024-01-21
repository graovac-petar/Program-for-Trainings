using System;

namespace Common.Communication
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object Body { get; set; }
    }
}
