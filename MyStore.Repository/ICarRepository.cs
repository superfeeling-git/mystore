namespace MyStore.Repository
{
    public interface ICarRepository
    {
<<<<<<< HEAD
        void SetValue(string key, object value);
        string[] GetKeys(string pattern);
        string GetValue(string key);
        long Del(string key);
=======
        void AddCar(string key, object value);
>>>>>>> a1ffbe36c9d6c1a7dd7c522efdfbd9265a734add
    }
}