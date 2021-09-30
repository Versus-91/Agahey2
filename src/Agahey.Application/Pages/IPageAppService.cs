using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agahey.Pages
{
    public interface IPageAppService : IAsyncCrudAppService<PageDto, int>
    {
    }
}
