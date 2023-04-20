namespace dotnetmrabug.Data.Interfaces
{
    public interface IDelete<in T>
    {
        bool Delete(T id);
    }
}
