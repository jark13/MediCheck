namespace MediCheck.Data;

using MediCheck.Entities;
using Microsoft.EntityFrameworkCore;

public class MediCheckDbContext : DbContext
{
    public DbSet<HospitalStaff> Employees => Set<HospitalStaff>();
    public DbSet<BusinessPartners> BusinessPartners => Set<BusinessPartners>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageAppDb");
    }
}


//using MediCheck.Entities;
//using Microsoft.EntityFrameworkCore;

//namespace MediCheck.Data
//{
//    public class MediCheckDbContext : DbContext
//    {
//        public DbSet<HospitalStaff> HospitalStaff => Set<HospitalStaff>();

//        public DbSet<BusinessPartners> BusinessPartners => Set<BusinessPartners>();

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            base.OnConfiguring(optionsBuilder);
//            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
//        }
//    }
//}
