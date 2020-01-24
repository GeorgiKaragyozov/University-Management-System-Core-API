using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class Departament : NamedPersistent
    {
        public virtual DepartamentStatus Status { get; set; }
    }
}
