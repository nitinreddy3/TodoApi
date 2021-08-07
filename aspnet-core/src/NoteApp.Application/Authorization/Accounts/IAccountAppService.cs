using System.Threading.Tasks;
using Abp.Application.Services;
using NoteApp.Authorization.Accounts.Dto;

namespace NoteApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
