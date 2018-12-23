using FakturyZakupu.Bll.Interfaces;
using FakturyZakupu.Dal.Interfaces;
using FakturyZakupu.Domain;

namespace FakturyZakupu.Bll
{
    public class FakturyZakupuService : IFakturyZakupuService
    {
        private readonly IFakturyZakupuRepository fakturyZakupuRepository;

        public FakturyZakupuService(IFakturyZakupuRepository fakturyZakupuRepository)
        {
            this.fakturyZakupuRepository = fakturyZakupuRepository;
        }

        public FakturaZakupuDomain GetFakturaZakupu(int id)
        {
            return fakturyZakupuRepository.Get(id);
        }
    }
}
