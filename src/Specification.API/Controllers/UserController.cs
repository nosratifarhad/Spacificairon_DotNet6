using Microsoft.AspNetCore.Mvc;
using Specification.Application.DTOs;
using Specification.Application.Services.Contracts;

namespace MyApp.WebApi.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {
        #region [ Fields ]

        private readonly IUserService _userService;

        #endregion [ Fields ]

        #region [ Ctor ]

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion [ Ctor ]

        /// <summary>
        /// GetAllUsersAsync
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("users/get-all")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var result = await _userService.GetAllUsersAsync();

            return Ok(result);
        }

        /// <summary>
        /// CreateUser
        /// </summary>
        /// <param name="createUserDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("users/create")]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            int userId = await _userService.CreateUser(createUserDto);

            return CreatedAtRoute(nameof(GetUserByIdAsync), new { userId = userId }, new { UserId = userId });
        }

        /// <summary>
        /// GetUserByIdAsync
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("users/{userId:int}")]
        public async Task<IActionResult> GetUserByIdAsync(int userId)
        {
            return Ok(userId);
        }

    }
}
