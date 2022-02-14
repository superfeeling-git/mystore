using MyStore.Dto;

namespace MyStore.Service
{
    public interface IUserService
    {
        LoginDto Login(UserDto userDto);
    }
}