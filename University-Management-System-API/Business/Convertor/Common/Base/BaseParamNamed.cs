namespace University_Management_System_API.Business.Convertor
{
    public abstract class BaseParamNamed : BaseParam
    {
        //[ParamProperty(IsIgnore = true)]
        public string Code { get; set; }

        //[ParamProperty(IsIgnore = false)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
