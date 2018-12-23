using Dapper;
using FakturyZakupu.Dal.Interfaces;
using FakturyZakupu.Domain;
using System;

namespace FakturyZakupu.Dal
{
    public class FakturyZakupuRepository : IFakturyZakupuRepository
    {
        private readonly IFakturyZakupuConnectionProvider provider;

        public FakturyZakupuRepository(IFakturyZakupuConnectionProvider provider)
        {
            this.provider = provider;
        }

        public FakturaZakupuDomain Get(int id)
        {
            using (var connection = provider.GetConnection())
            {
                return connection.QuerySingle<FakturaZakupuDomain>("SELECT * FROM FakturyZakupu WHERE Id = @Id", new { @Id = id });
            }
        }
    }
}
