using Swashbuckle.AspNetCore.Filters;
using SmartCentral.Contracts.V1.Requests;

namespace SmartCentral.SwaggerExamples.Requests
{
    public class CreateTagRequestExample : IExamplesProvider<CreateTagRequest>
    {
        public CreateTagRequest GetExamples()
        {
            return new CreateTagRequest
            {
                TagName = "new tag"
            };
        }
    }
}