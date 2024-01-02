using MediCheck.Entities;

namespace MediCheck.Repositories
{
    //using MadiCheck.Entities;
    public class HospitalStaffRepository
    {
        private readonly List<HospitalStaff> _hospitalStaff = new();

        public void Add(HospitalStaff hospitalStaff)
        {
            hospitalStaff.Id = _hospitalStaff.Count + 1;
            _hospitalStaff.Add(hospitalStaff);
        }

        public void Save()
        {
            foreach (var hospitalStaff in _hospitalStaff)
            {
                Console.WriteLine(hospitalStaff);
            }
        }

        public HospitalStaff GetById(int id)
        {
            return _hospitalStaff.Single(item => item.Id == id);
        }
    }
}
