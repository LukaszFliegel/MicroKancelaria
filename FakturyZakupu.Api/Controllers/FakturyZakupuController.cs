using AutoMapper;
using Base.Api;
using FakturyZakupu.Bll.Interfaces;
using FakturyZakupu.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace FakturyZakupu.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class FakturyZakupuController : BaseController
    {
        private readonly IFakturyZakupuService fakturyZakupuService;

        public FakturyZakupuController(IMapper mapper, IFakturyZakupuService fakturyZakupuService)
            : base(mapper)
        {
            this.fakturyZakupuService = fakturyZakupuService;
        }

        [HttpGet]
        public FakturaZakupuDto Get(int id)
        {
            var fakturaZakupu = fakturyZakupuService.GetFakturaZakupu(id);

            return mapper.Map<FakturaZakupuDto>(fakturaZakupu);
        }
    }
}
