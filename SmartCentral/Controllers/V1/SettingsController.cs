using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartCentral.Contracts.V1;

namespace SmartCentral.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SettingsController : Controller
    {
        [HttpGet(ApiRoutes.Settings.GetSpcSettings)]
        public async Task GetSpcSettings()
        {

        }

        [HttpPut(ApiRoutes.Settings.UpdateSpcSettings)]
        public async Task UpdateSpcSettings()
        {

        }

        [HttpPost(ApiRoutes.Settings.CreateSpcSettings)]
        public async Task CreateSpcSettings()
        {

        }

        [HttpDelete(ApiRoutes.Settings.DeleteSpcSettings)]
        public async Task DeleteSpcSettings()
        {

        }

        [HttpGet(ApiRoutes.Settings.GetSyncoLivingSettings)]
        public async Task GetSyncoLivingSettings()
        {

        }

        [HttpPut(ApiRoutes.Settings.UpdateSyncoLivingSettings)]
        public async Task UpdateSyncoLivingSettings()
        {

        }

        [HttpPost(ApiRoutes.Settings.CreateSyncoLivingSettings)]
        public async Task CreateSyncoLivingSettings()
        {

        }

        [HttpDelete(ApiRoutes.Settings.DeleteSyncoLivingSettings)]
        public async Task DeleteSyncoLivingSettings()
        {

        }
    }
}