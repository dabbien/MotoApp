namespace MotoApp.Repositories
{
    using MotoApp.Entities;
    public class GenericRepository<TEntity, TKey>
        where TEntity : class, IEntity, new()
        where TKey : struct
    {
        public TEntity CreateNewItem()
        {
            return new TEntity();
        }
        public TKey? Key { get; set; }
        protected readonly List<TEntity> _items = new();
        public void Add(TEntity item)
        {
            item.ID = _items.Count + 1;
            _items.Add(item);
        }
        public TEntity GetById(int id)
        {
            return _items.Single(item => item.ID == id);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
