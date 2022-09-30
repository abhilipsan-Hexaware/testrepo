namespace dotnetbackend - 7.Data.Interfaces
{
    public interface IUpdate<T, U> where T : class
    {
        T Update(U id, T entity);
    }
}
