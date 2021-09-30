using System.Collections.Generic;
using Agahey.Roles.Dto;

namespace Agahey.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
