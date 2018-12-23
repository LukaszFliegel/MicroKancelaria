using Base.Domain;
using System;

namespace FakturyZakupu.Domain
{
    public class FakturaZakupuDomain : DomainModel
    {
        public string NumerFaktury { get; set; }
        public string WlasnyNumerFaktury { get; set; }
        public DateTime DataFaktury { get; set; }
        public int IdKontrahenta { get; set; }
        public int IdSposobuPlatnosci { get; set; }
        public DateTime TerminPlatnosci { get; set; }
        public DateTime DataZakupu { get; set; }
    }
}
