using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace YoutubeSub.Service
{
    public class SenderService : ISender
    {
        private HttpRequestMessage httpRequestMessage;
        private HttpClient httpClient;

        public SenderService()
        {
            httpRequestMessage = new HttpRequestMessage();
            httpClient = new HttpClient();
        }

        public string Send(string uri)
        {
            string result = "";
            httpRequestMessage.RequestUri = new Uri(uri);
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.Headers.Add("Accept", "application/xml");

            Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

            HttpResponseMessage httpResponseMessage = httpResponse.Result;

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            if (statusCode.ToString()=="OK")
            {
                HttpContent responseContent = httpResponseMessage.Content;
                Task<string> responseData = responseContent.ReadAsStringAsync();
                string data = responseData.Result;

                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(data);
                    result = xmlDoc.InnerText;
                }
                catch (ArgumentNullException e)
                {
                    MessageBox.Show(e.ToString(), "Exception");
                }
            }
            httpClient.Dispose();
           
            return result;
        }
    }
}
