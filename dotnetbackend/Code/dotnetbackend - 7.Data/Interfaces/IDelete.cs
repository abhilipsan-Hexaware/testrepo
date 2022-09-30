namespace dotnetbackend - 7.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
