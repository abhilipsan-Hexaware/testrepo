namespace dotnetbackend - 8.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
