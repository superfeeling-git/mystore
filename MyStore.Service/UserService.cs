using System;
using MyStore.Repository;
using MyStore.Entity;
using MyStore.Dto;
using Microsoft.AspNetCore.Http;

namespace MyStore.Service
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository;
        private IHttpContextAccessor httpContext;

        public UserService(IUserRepository UserRepository, IHttpContextAccessor httpContext)
        {
            this.UserRepository = UserRepository;
            this.httpContext = httpContext;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userDto"></param>
        /// <returns></returns>
        public LoginDto Login(UserDto userDto)
        {
            var user = UserRepository.GetEntity(userDto.UserName);
            if (user == null)
            {
                return new LoginDto { Msg = "无此用户", StatusCode = 1 };
            }
            else
            {
                if (user.Password.ToLower() != userDto.Password.ToLower())
                {
                    return new LoginDto { Msg = "密码不对", StatusCode = 2 };
                }
                else
                {
                    //写Cookies
                    httpContext.HttpContext.Response.Cookies.Append("UserName", userDto.UserName, new CookieOptions { HttpOnly = true });

                    return new LoginDto { StatusCode = 0 };
                }
            }
        }
    }
}
