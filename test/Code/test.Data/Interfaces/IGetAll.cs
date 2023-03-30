using System.Collections.Generic;

namespace test.Data.Interfaces
{
    public interface IGetAll<out T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
