namespace dotnetbackend - 10.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
