using System.Collections.Generic;

namespace test2015.Areas.IdentityManagement.Models
{
    public class ActionStatus
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public List<ActionError> Errors { get; set; }
        public dynamic Data { get; set; }
    }
}