using System.Threading.Tasks;
using SmartCentral.Domain;

namespace SmartCentral.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        
        Task<AuthenticationResult> LoginAsync(string email, string password);
        
        Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
    }
}