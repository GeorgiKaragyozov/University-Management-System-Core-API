using System.ComponentModel.DataAnnotations;
using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor
{
    public abstract class BaseParamNamed : BaseParam
    {
        //[ParamProperty(IsIgnore = true)]
        [Required]
        public string Code { get; set; }

        //[ParamProperty(IsIgnore = false)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
