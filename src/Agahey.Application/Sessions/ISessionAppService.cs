using System.Threading.Tasks;
using Abp.Application.Services;
using Agahey.Sessions.Dto;

namespace Agahey.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
