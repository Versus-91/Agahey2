using System.Collections.Generic;
using Agahey.Roles.Dto;

namespace Agahey.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}