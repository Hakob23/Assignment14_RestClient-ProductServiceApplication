using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsRESTClient
{

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }


    class RESTClient
    {
        public string Request { get; set; }
        public httpVerb HttpMethod { get; set; }

        public RESTClient(httpVerb verb, string _request)
        {
            Request = _request;
            HttpMethod = verb;
        }

        public string MakeRequest()
        {
            string strResponseValue = null;

            HttpWebResponse response = null;

            try
            {          
                HttpWebRequest httpRequest =(HttpWebRequest)WebRequest.Create(Request);

                httpRequest.Method = HttpMethod.ToString();

                response = (HttpWebResponse)httpRequest.GetResponse();

                using(Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                strResponseValue = ex.Message;
            }

            return strResponseValue;
        }

    }
}
