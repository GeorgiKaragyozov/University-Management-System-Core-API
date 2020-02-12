using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor
{
    public abstract class BaseParamNamed : BaseParam
    {
        [ParamProperty(true)]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
