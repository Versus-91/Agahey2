using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agahey.Tags.Dto
{
    public class TagDto : AuditedEntityDto
    {

        public string Name { get; set; }

        public int ItemsCount { get; set; }

        public int ClickCount { get; set; }

    }
}
 