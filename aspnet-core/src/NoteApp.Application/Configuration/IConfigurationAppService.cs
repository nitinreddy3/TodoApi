using System.Threading.Tasks;
using NoteApp.Configuration.Dto;

namespace NoteApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
