namespace MyStore.Repository
{
    public interface ICarRepository
    {
        void SetValue(string key, object value);
        string[] GetKeys(string pattern);
        string GetValue(string key);
        long Del(string key);
    }
}