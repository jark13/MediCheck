namespace MediCheck.Repositories
{
    using MediCheck.Entities.Repositories;
    using MediCheck.Entities;
   
    public class ListRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly List<T> _items = new();
        public IEnumerable<T> GetAll()
        {
            return _items;
        }
        public T GetById(int id)
        {
            //return default(T);
            return _items.Single(item => item.Id == id);
        }
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public void Save()
        {
            //save is not required with List


            //foreach (var item in _items)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
    //public class ListRepository<T, TKey> 
    //    where T : class, IEntity, new()
    //    where TKey : struct


    //{
    //    public T CreateNewItem()
    //    {
    //        return new T();
    //    }

    //    public TKey? Key { get; set; }
    //    protected readonly List<T> _items = new();

    //    public void Add(T item)
    //    {
    //        item.Id = _items.Count + 1;
    //        _items.Add(item);
    //    }

    //    public void Save()
    //    {
    //        foreach (var item in _items)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    public T GetById(int id)
    //    {
    //        return default(T);
    //        //return _items.Single(item => item.Id == id);
    //    }
    //}
}
