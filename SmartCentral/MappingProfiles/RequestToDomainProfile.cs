using AutoMapper;
using SmartCentral.Contracts.V1.Requests.Queries;
using SmartCentral.Domain;

namespace SmartCentral.MappingProfiles
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<GetAllPostsQuery, GetAllPostsFilter>();
        }
    }
}