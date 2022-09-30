using System.Collections.Generic;

namespace dotnetbackend - 9.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
