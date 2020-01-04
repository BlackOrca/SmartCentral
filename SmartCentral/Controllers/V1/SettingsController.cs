using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCentral.Contracts.V1;
using SmartCentral.Contracts.V1.Requests;
using SmartCentral.Contracts.V1.Responses;
using SmartCentral.Data;
using SmartCentral.Domain;
using SmartCentral.Services;

namespace SmartCentral.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SettingsController : Controller
    {
        private readonly DataContext DbContext;
        private readonly IMapper Mapper;

        public SettingsController(DataContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }


        [HttpGet(ApiRoutes.Settings.GetSpcSettings)]
        public async Task<IActionResult> GetSpcSettings()
        {
            var spc = await DbContext.Spcs.FirstOrDefaultAsync();
            if (spc == null)
                return NoContent();

            return Ok(Mapper.Map<SpcResponse>(spc));
        }

        [HttpPut(ApiRoutes.Settings.UpdateSpcSettings)]
        public async Task UpdateSpcSettings()
        {

        }

        [HttpPost(ApiRoutes.Settings.CreateSpcSettings)]
        public async Task<IActionResult> CreateSpcSettings([FromBody] CreateSpcRequest createRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(new ErrorResponse(new ErrorModel() { FieldName = "Model", Message = "Not Valid!" }));


            var spc = await DbContext.Spcs.FirstOrDefaultAsync();
            if (spc != null)
                return BadRequest(new ErrorResponse(new ErrorModel() { FieldName = "General", Message = "SPC Settings exits. Use UpdateSpcSettings to change it." }));

            var newSpc = new SpcAlarmSystem()
            {
                Ip = createRequest.Ip,
                Name = createRequest.Name,
                Port = createRequest.Port,
                UseHttps = createRequest.UseHttps,
                ApiUser = createRequest.ApiUser,
                ApiPassword = createRequest.ApiPassword,
            };

            DbContext.Spcs.Add(newSpc);
            await DbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSpcSettings), null);
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