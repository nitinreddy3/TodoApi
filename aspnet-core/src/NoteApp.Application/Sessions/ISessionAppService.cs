using System.Threading.Tasks;
using Abp.Application.Services;
using NoteApp.Sessions.Dto;

namespace NoteApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
