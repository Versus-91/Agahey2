using Abp.Domain.Entities.Auditing;
using Agahey.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agahey.SubCategories
{
    public class SubCategory : AuditedEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

    }
}
