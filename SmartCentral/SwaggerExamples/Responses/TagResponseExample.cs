using Swashbuckle.AspNetCore.Filters;
using SmartCentral.Contracts.V1.Responses;

namespace SmartCentral.SwaggerExamples.Responses
{
    public class TagResponseExample : IExamplesProvider<TagResponse>
    {
        public TagResponse GetExamples()
        {
            return new TagResponse
            {
                Name = "new tag"
            };
        }
    }
}