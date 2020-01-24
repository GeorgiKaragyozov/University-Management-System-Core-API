using University_Management_System_API.Business.Convertor.SpecialityTrainingType;
using University_Management_System_API.Business.Processor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.SpecialityTrainingType;

namespace University_Management_System_API.Business.Processor.SpecialityTrainingType
{
    public class SpecialityTrainingTypeProcessor
         : BaseProcessor<ISpecialityTrainingTypeParamConverter, ISpecialityTrainingTypeResultConverter,
            SpecialityTrainingTypeParam, SpecialityTrainingTypeResult, ISpecialityTrainingTypeDao,
            long, Model.SpecialityTrainingType>, ISpecialityTrainingTypeProcessor
    {
        protected override long GetTPK(SpecialityTrainingTypeParam param)
        {
            return param.Id;
        }

        public SpecialityTrainingTypeProcessor(ISpecialityTrainingTypeDao dao,
            ISpecialityTrainingTypeParamConverter paramConverter,
            ISpecialityTrainingTypeResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {

        }
    }
}
