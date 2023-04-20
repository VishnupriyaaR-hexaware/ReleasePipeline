using System.Collections.Generic;

namespace dotnetmrabug.Data.Interfaces
{
    public interface IGetAll<out T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
