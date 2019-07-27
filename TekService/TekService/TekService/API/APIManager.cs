using System;
using System.Collections.Generic;
using System.Text;

namespace TekService.API
{
    using Newtonsoft;

    public class APIManager
    {
        private static Member member;

        public static Member Member
        {
            get { return member = member ?? new Member(); }
            set { member = value; }
        }


    }


}
