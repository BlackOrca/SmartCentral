using System.Linq;
using AutoMapper;
using SmartCentral.Contracts.V1.Responses;
using SmartCentral.Domain;

namespace SmartCentral.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Post, PostResponse>()
                .ForMember(dest => dest.Tags, opt => 
                    opt.MapFrom(src => src.Tags.Select(x => new TagResponse{Name = x.TagName})));
            
            CreateMap<Tag, TagResponse>();

            CreateMap<SpcAlarmSystem, SpcResponse>();
        }
    }
}