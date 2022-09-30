using System.Collections.Generic;

namespace dotnetbackend - 6.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
