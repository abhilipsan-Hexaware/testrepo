namespace dotnetbackend - 9.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
