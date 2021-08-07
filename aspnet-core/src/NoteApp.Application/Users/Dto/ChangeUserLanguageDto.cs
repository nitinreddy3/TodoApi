using System.ComponentModel.DataAnnotations;

namespace NoteApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}