using System.ComponentModel.DataAnnotations;

namespace University_Management_System_API.Business.Convertor.User
{
    public class UserParam : BaseParam
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public long StatusId { get; set; }
    }
}

