using MyStore.Dto;
using MyStore.Entity;

namespace MyStore.Service
{
    public interface IUserService
    {
        LoginDto Login(UserDto userDto);
        /// <summary>
        /// 获取当前用户信息
        /// </summary>
        /// <returns></returns>
        User LoginInfo();
    }
}