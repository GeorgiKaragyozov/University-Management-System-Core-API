using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor
{
    public abstract class BaseParam
    {
        //[ParamProperty(IsIgnore = true)]
        public long Id { get; set; }
    }
}
