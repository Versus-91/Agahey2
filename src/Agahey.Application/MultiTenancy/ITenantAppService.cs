using Abp.Application.Services;
using Agahey.MultiTenancy.Dto;

namespace Agahey.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

