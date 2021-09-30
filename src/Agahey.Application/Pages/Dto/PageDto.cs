using Abp.Application.Services.Dto;
using Agahey.Categories;
using Agahey.Tags;
using System.Collections.Generic;

namespace Agahey.Pages
{
    public class PageDto : EntityDto
    {
        public string Name { get; set; }

        public string Descriptiuon { get; set; }

        public string ImageSrc { get; set; }

        public Category Category { get; set; }

        public int Views { get; set; } = 0;

        public IList<Tag> Tags { get; set; }
    }
}
