﻿using Abp.Domain.Entities.Auditing;
using Agahey.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agahey.Tags
{
    public class Tag : AuditedEntity
    {

        public string Name { get; set; }

        public int ItemsCount { get; set; }

        public int ClickCount { get; set; }

        public IList<Page> Pages { get; set; }

    }
}
