using System.Collections.Generic;
using Agahey.Roles.Dto;

namespace Agahey.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
