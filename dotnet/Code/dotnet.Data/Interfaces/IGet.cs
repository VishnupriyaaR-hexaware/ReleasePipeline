using System.Collections.Generic;

namespace  dotnet.Data.Interfaces
{
    public interface IGet<out T,in TKey> where T : class
    {
        T Get(TKey id) ;
    }
}
