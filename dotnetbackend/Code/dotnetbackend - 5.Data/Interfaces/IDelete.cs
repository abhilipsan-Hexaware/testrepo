namespace dotnetbackend - 5.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
