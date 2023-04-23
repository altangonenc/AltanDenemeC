namespace AltanDenemeC.Repository
{
    public interface IEfRepository<T> : IGenericRepository<T> where T : class, new()
    {
        public T Add(T entity);

        public T Delete(T entity);

        public List<T> GetAll();

        public T GetById(int id);

        public T UpdateById(T entity, int id);

        public bool DeleteAll();
    }
}