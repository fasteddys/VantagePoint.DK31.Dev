using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serenity.Data;

namespace VantagePoint.Administration
{
    public interface IMultiTenantRow
    {
        GuidField TenantId { get; }
    }
}
