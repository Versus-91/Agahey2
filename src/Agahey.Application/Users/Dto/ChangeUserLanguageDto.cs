using System.ComponentModel.DataAnnotations;

namespace Agahey.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}