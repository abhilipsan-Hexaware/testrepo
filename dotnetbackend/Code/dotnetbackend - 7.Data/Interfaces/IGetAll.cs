using System.Collections.Generic;

namespace dotnetbackend - 7.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
