using Abp.Application.Services;
using Abp.Domain.Repositories;
using Agahey.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agahey.Pages
{
    public class PageAppService : AsyncCrudAppService<Page,PageDto,int>, IPageAppService
    {
        private readonly IRepository<Page> _pageRepository;
        public PageAppService(IRepository<Page> pageRepository) :base(pageRepository)
        {
            _pageRepository = pageRepository;
        }
    }
}
