using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.API.Request
{
    public partial class MemberRequest
    {
        public Device Device { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }

    public partial class Device
    {
        public string AppVersion { get; set; }
        public string DId { get; set; }
        public string Imei { get; set; }
        public string Mac { get; set; }
        public string Model { get; set; }
        public string Operator { get; set; }
        public string Serial { get; set; }
        public string SystemName { get; set; }
        public string SystemVersion { get; set; }
        public string Token { get; set; }
    }

}
