namespace dotnetbackend - 6.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
