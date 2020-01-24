using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.EducationalDegree
{
    public class EducationalDegreeResultConverter   
         : BaseResultConverter<Model.EducationalDegree, EducationalDegreeResult>,
        IEducationalDegreeResultConverter
    {
        public override void ConvertSpecific(Model.EducationalDegree param,
            EducationalDegreeResult result)
        { }

        public override EducationalDegreeResult GetResult()
        {
            return new EducationalDegreeResult();
        }
    }
}
