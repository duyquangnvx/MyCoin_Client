using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyCoin.Util
{
    public class HttpClientUtil
    {
        private HttpClient httpClient;
        private static HttpClientUtil instance;
        public static HttpClientUtil Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HttpClientUtil();
                }
                return instance;
            }
        }

        private HttpClientUtil()
        {
            this.httpClient = new HttpClient();
        }

        public static void Post()
        {

        }
    }
}
