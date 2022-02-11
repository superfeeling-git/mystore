using MyStore.Entity;

namespace MyStore.Repository
{
    public interface IUserRepository
    {
        User GetEntity(string UserName);
    }
}