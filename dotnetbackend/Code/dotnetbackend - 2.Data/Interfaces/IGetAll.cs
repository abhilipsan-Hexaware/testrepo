using System.Collections.Generic;

namespace dotnetbackend - 2.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
