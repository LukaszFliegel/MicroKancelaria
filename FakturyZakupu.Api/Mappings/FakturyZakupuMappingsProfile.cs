using AutoMapper;
using FakturyZakupu.Contracts;
using FakturyZakupu.Domain;

namespace FakturyZakupu.Api.Mappings
{
    public class FakturyZakupuMappingsProfile : Profile
    {
        public FakturyZakupuMappingsProfile()
        {
            CreateMap<FakturaZakupuDomain, FakturaZakupuDto>();
        }
    }
}
