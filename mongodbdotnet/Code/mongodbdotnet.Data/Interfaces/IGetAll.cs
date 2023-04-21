using System.Collections.Generic;

namespace mongodbdotnet.Data.Interfaces
{
    public interface IGetAll<out T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
