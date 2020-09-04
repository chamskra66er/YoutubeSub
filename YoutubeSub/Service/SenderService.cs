using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSub.Service
{
    public class SenderService : ISender
    {
        private HttpRequestMessage httpRequestMessage;
        public SenderService()
        {
            httpRequestMessage = new HttpRequestMessage();
        }

        public async Task SendAsync(string uri)
        {

        }
    }
}
