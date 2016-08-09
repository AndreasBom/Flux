using System.Threading.Tasks;
using Abp.Application.Services;
using Flux.Roles.Dto;

namespace Flux.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}