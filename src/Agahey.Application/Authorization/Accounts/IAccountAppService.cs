using System.Threading.Tasks;
using Abp.Application.Services;
using Agahey.Authorization.Accounts.Dto;

namespace Agahey.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
