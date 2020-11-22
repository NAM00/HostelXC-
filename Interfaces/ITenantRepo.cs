using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public interface ITenantRepo
    {
        bool InsertTenant(Tenant te);
        bool DeleteTenant(Tenant te);
        bool UpdateTenant(Tenant te);
        Tenant GetTenant(string tenId);
        List<Tenant> GetAllTenant();
    }
}
