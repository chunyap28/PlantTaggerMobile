using System;
using System.Net.Http;
using System.Threading.Tasks;
using Plant_Tagger.Configs;
using Plant_Tagger.Models;

namespace Plant_Tagger.Services
{
    public class AuthService : IAuthService
    {
        IRequestProvider _requestProvider;

        public AuthService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<AccessToken> Login(string email, string password){
            string uri = Constants.PtBasedUrl + "auth";

            MultipartFormDataContent param = new MultipartFormDataContent();
            param.Add(new StringContent(email), "userID");
            param.Add(new StringContent(password), "password");
            param.Add(new StringContent("PASSWORD"), "type");

            var token = await _requestProvider.PostAsync<AccessToken>(uri, param);
            return token;
        }
    }
}
