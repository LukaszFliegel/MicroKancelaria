using FakturyZakupu.Domain;
using System;

namespace FakturyZakupu.Dal.Interfaces
{
    public interface IFakturyZakupuRepository
    {
        FakturaZakupuDomain Get(int id);
    }
}
