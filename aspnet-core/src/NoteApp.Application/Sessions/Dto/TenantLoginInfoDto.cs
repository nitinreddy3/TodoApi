using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoteApp.MultiTenancy;

namespace NoteApp.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
