using Abp.Application.Services;
using NoteApp.MultiTenancy.Dto;

namespace NoteApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

