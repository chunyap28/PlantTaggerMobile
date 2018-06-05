using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Plant_Tagger.Configs;

namespace Plant_Tagger.Services
{
    public class AuthService
    {
        HttpClient client;

        public AuthService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<string> Login(string email, string password){            
            var uri = new Uri(Constants.PtBasedUrl + "auth");

            try
            {
                MultipartFormDataContent param = new MultipartFormDataContent();

                param.Add(new StringContent(email), "userID");
                param.Add(new StringContent(password), "password");
                param.Add(new StringContent("PASSWORD"), "type");

                //var content = new StringContent(JsonConvert.SerializeObject(param, Formatting.Indented), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(uri, param);

                System.Diagnostics.Debug.WriteLine("Login Request: " + response.RequestMessage.ToString());
                System.Diagnostics.Debug.WriteLine("Login Response: " + response.ToString());

                if (response.IsSuccessStatusCode)
                {
                    var contents = await response.Content.ReadAsStringAsync();

                    return contents;
                }

                throw new Exception();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Login Error: " + ex.Message);
                return null;
            }
        }
    }
}
