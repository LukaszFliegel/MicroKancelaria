using FakturyZakupu.Domain;
using System;

namespace FakturyZakupu.Bll.Interfaces
{
    public interface IFakturyZakupuService
    {
        FakturaZakupuDomain GetFakturaZakupu(int id);
    }
}
