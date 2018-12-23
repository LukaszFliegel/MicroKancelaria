using System;

namespace FakturyZakupu.Contracts
{
    public class FakturaZakupuDto
    {
        public int Id { get; set; }
        public string WlasnyNumerFaktury { get; set; }
        public DateTime DataFaktury { get; set; }
        public int IdKontrahenta { get; set; }
        public int IdSposobuPlatnosci { get; set; }
        public DateTime TerminPlatnosci { get; set; }
        public DateTime DataZakupu { get; set; }
    }
}
