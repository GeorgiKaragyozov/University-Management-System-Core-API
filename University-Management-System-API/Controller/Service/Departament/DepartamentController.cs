using University_Management_System_API.Business.Convertor.Departament;
using University_Management_System_API.Business.Processor.Departament;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.Departament
{
    public class DepartamentController 
        : BaseController<DepartamentParam, DepartamentResult, long, IDepartamentProcessor>
    {
        public DepartamentController(IDepartamentProcessor processor)
           : base(processor)
        {

        }
    }
}
