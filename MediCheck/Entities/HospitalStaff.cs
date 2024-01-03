namespace MediCheck.Entities
{
    public class HospitalStaff : EntityBase
    {       
        public string? FirstName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}";
    }
}
