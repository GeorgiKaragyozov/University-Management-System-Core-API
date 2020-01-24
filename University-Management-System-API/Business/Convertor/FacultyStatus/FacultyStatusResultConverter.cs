using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.FacultyStatus
{
    public class FacultyStatusResultConverter 
        : BaseResultConverter<Model.FacultyStatus, FacultyStatusResult>, IFacultyStatusResultConverter
    {
        public override void ConvertSpecific(Model.FacultyStatus param, FacultyStatusResult result) { }

        public override FacultyStatusResult GetResult()
        {
            return new FacultyStatusResult();
        }
    }
}
