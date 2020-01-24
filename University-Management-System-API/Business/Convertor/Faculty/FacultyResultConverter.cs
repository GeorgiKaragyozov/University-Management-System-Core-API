using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Faculty
{
    public class FacultyResultConverter 
        : BaseResultConverter<Model.Faculty, FacultyResult>, IFacultyResultConverter
    {
        public override void ConvertSpecific(Model.Faculty param, FacultyResult result)
        {
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override FacultyResult GetResult()
        {
            return new FacultyResult();
        }
    }
}
