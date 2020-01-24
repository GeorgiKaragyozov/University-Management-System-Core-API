namespace University_Management_System_API.Model
{
    public class Account : NamedPersistent
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Egn { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }

        public virtual User User { get; set; }

        public virtual AccountStatus Status { get; set; }

        public virtual Speciality Speciality { get; set; }

        public virtual Departament Departament { get; set; }

        public virtual AccountType TypeAccount { get; set; }
    }
}

