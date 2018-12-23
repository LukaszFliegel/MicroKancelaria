using System.Data.Common;
using System.Data.SqlClient;
using FakturyZakupu.Dal.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FakturyZakupu.Dal
{
    public class FakturyZakupuConnectionProvider : IFakturyZakupuConnectionProvider
    {
        private readonly string connectionString;
        private readonly IConfiguration configuration;

        public FakturyZakupuConnectionProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.connectionString = configuration["ConnectionString"];
        }        

        public DbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
