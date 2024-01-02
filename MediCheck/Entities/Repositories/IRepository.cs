namespace MediCheck.Entities.Repositories;

using MediCheck.Entities;
public interface IRepository<T> :IReadRepository<T>, IWriteRepository<T>
    where T : class, IEntity
{
}


//using MediCheck.Entities;

//namespace MediCheck.Entities.Repositories
//{
//    public interface IRepository<T> where T : class, IEntity
//    {
//        IEnumerable<T> GetAll();
//        T GetById(int id);
//        void Add(T item);
//        void Remove(T item);
//        void Save(T item);
//    }
//}
