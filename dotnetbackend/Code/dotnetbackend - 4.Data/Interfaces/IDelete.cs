namespace dotnetbackend - 4.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
