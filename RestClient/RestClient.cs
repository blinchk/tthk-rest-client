using System;
using System.IO;
using System.Net;

namespace RestClient
{
    public class RestClient
    {
        public static HttpWebRequest BuildRequest(string endpoint, HttpMethod method = HttpMethod.GET)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endpoint);
            request.Method = method.ToString();
            return request;
        }

        public string SendRequest(HttpWebRequest request)
        {
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse) request.GetResponse();

                using Stream responseStream = response.GetResponseStream();
                using StreamReader reader = new StreamReader(responseStream);
                return reader.ReadToEnd();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                if (response != null) response.Dispose();
            }
        }
    }

}