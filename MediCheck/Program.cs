using MediCheck.Data;
using MediCheck.Entities;
using MediCheck.Entities.Repositories;
using MediCheck.Repositories;

//var hospitalStaffRepository = new MediCheck.Entities.Repositories.HospitalStaffRepository();
//var hospitalStaffRepository = new GenericRepository<HospitalStaff, Guid>();
//hospitalStaffRepository.Add(new MediCheck.Entities.HospitalStaff { FirstName = "Adam" });
//hospitalStaffRepository.Add(new MediCheck.Entities.HospitalStaff { FirstName = "Piotr" });
//hospitalStaffRepository.Add(new MediCheck.Entities.HospitalStaff { FirstName = "Zuzia" });
//hospitalStaffRepository.Save();

//var sqlRepository = new SqlRepository<HospitalStaff>(new MediCheckDbContext());
//sqlRepository.Add(new MediCheck.Entities.HospitalStaff { FirstName = "Adam" });
//sqlRepository.Add(new MediCheck.Entities.HospitalStaff { FirstName = "Piotr" });
//sqlRepository.Add(new MediCheck.Entities.HospitalStaff { FirstName = "Zuzia" });
//sqlRepository.Save();
//var emp = sqlRepository.GetById(1);
//Console.WriteLine(emp.ToString());

var hospitalStaffRepository = new SqlRepository<HospitalStaff>(new MediCheckDbContext());
AddEmployees(hospitalStaffRepository);
AddManagers(hospitalStaffRepository);
WriteAllToConsole(hospitalStaffRepository);


static void AddEmployees(IRepository<HospitalStaff> hospitalStaffRepository)
{
    hospitalStaffRepository.Add(new HospitalStaff { FirstName = "Adam" });
    hospitalStaffRepository.Add(new HospitalStaff { FirstName = "Piotr" });
    hospitalStaffRepository.Add(new HospitalStaff { FirstName = "Zuzanna" });
    hospitalStaffRepository.Save();
}


static void AddManagers(IWriteRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Przemek" });
    managerRepository.Add(new Manager { FirstName = "Tomek" });
    managerRepository.Save();
}
static void WriteAllToConsole(IReadRepository<IEntity> repository)
{

    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
