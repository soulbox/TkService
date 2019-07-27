using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TekService.API
{
   public  class BaseAPI
    {
        static  HttpClient _client;
        static HttpRequestMessage _request;
        public static HttpClient Client  => _client = _client ?? new HttpClient();
        public static HttpRequestMessage request => _request = _request ?? new HttpRequestMessage();
        public static StringContent content;
        public const string mediatype = "application/json";
        static BaseAPI()
        {

            Client.DefaultRequestHeaders.Add("Accept", mediatype);
        }
        public HttpRequestMessage GetRequest(string urlstr, string strcontent)
        {
            request.RequestUri =  new Uri(urlstr);
            request.Content = GetContent(strcontent);
            return request;
        }
        public  StringContent GetContent(string strcontent)
        {
            content = new StringContent(strcontent, Encoding.UTF8, mediatype);
            return content;
        }
    }
}
