using System;
using System.Threading.Tasks;
using Plant_Tagger.Models;

namespace Plant_Tagger.Services
{
    public interface IAuthService
    {
        Task<AccessToken> Login(string email, string password);
    }
}
