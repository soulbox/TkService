using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TekService.API.Request;
using TekService.API.Result;

namespace TekService.API
{
    public class Member : BaseAPI
    {
        static readonly string RequestURL = "http://api.hesap.tekservis.net/api/member/get";
        public Member() : base()
        {
            
            if (!Client.DefaultRequestHeaders.Contains("Accept"))
            {

                Client.DefaultRequestHeaders.Add("Accept", mediatype);
            }
        }

        public  async Task<MemberResponse> LoginAsync(MemberRequest memberRequest)
        {

            var seri = JsonConvert.SerializeObject(memberRequest);
            var response = await Client.PostAsync(RequestURL, GetContent(seri));
            var responsestr = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<MemberResponse>(responsestr);
        }
    }

}
