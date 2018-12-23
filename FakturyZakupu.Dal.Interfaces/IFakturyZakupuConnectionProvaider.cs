using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace FakturyZakupu.Dal.Interfaces
{
    public interface IFakturyZakupuConnectionProvider
    {
        DbConnection GetConnection();
    }
}
