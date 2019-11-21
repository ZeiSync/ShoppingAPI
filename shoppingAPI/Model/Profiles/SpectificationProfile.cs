using AutoMapper;
using shoppingAPI.Data.Entity;

namespace shoppingAPI.Model.Profiles
{
    public class SpectificationProfile : Profile
    {
        public SpectificationProfile()
        {
            this.CreateMap<Specification, SpectificationModel>()
                .ForMember(s => s.GrandPiano, x => x.MapFrom(t => t.GrandPiano))
                .ForMember(s => s.UprightPiano, x => x.MapFrom(t => t.UprightPiano))
                .ForMember(s => s.DigitalPiano, x => x.MapFrom(t => t.DigitalPiano)).ReverseMap();
        }
    }
}