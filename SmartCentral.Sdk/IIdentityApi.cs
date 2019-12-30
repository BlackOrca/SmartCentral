using System.Threading.Tasks;
using Refit;
using SmartCentral.Contracts.V1.Requests;
using SmartCentral.Contracts.V1.Responses;

namespace SmartCentral.Sdk
{
    public interface IIdentityApi
    {
        [Post("/api/v1/identity/register")]
        Task<ApiResponse<AuthSuccessResponse>> RegisterAsync([Body] UserRegistrationRequest registrationRequest);
        
        [Post("/api/v1/identity/login")]
        Task<ApiResponse<AuthSuccessResponse>> LoginAsync([Body] UserLoginRequest loginRequest);
        
        [Post("/api/v1/identity/refersh")]
        Task<ApiResponse<AuthSuccessResponse>> RefreshAsync([Body] RefreshTokenRequest refreshRequest);
    }
}