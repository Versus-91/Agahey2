using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agahey.Categories
{
    public class Category: AuditedEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
