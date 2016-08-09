using System.Threading.Tasks;
using Abp.Application.Services;
using Flux.Sessions.Dto;

namespace Flux.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}