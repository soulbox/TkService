using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.API.Result
{
    public partial class MemberResponse
    {
        public Guid Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AccountTitle { get; set; }
        public Header Header { get; set; }
    }

    public partial class Header
    {
        public bool HasError { get; set; }
        public object ErrorCode { get; set; }
        public object Message { get; set; }
    }

}
