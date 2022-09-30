namespace dotnetbackend - 3.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
