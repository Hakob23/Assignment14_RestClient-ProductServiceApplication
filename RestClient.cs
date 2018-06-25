using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment14_RestClient
{
   

    class RestClient
    {       

        public HttpWebResponse Response { get; set; }


        public HttpWebRequest MakeRequest(string httpVerb, string strRequest)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strRequest);

            request.Method = httpVerb.ToString();

            request.ContentLength = 0;

            return request;                       
        }


        public string MakeResponse(string httpVerb, string request)
        {
            string responseString;

            try
            {
                Response = (HttpWebResponse)MakeRequest(httpVerb, request).GetResponse();

                using(Stream responseStream = Response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        responseString = reader.ReadToEnd();
                    }
                }
            }

            catch(Exception ex)
            {
                responseString = ex.Message;
            }

            return responseString;            
        }
        

    }


}
