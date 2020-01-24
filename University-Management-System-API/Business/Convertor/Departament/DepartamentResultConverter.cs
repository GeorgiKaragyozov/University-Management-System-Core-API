using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Departament
{
    public class DepartamentResultConverter 
        : BaseResultConverter<Model.Departament, DepartamentResult>, IDepartamentResultConverter
    {
        public override void ConvertSpecific(Model.Departament param, DepartamentResult result)
        {
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override DepartamentResult GetResult()
        {
            return new DepartamentResult();
        }
    }
}
