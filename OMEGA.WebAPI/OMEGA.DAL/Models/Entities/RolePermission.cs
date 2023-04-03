using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("ROLE_PERMISSION")]
public partial class RolePermission
{
    [Key]
    [Column("role_id_permission")]
    public int RoleIdPermission { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("module_id")]
    public int? ModuleId { get; set; }

    [Column("sub_module_id")]
    public int? SubModuleId { get; set; }

    [Column("permission_id")]
    public int? PermissionId { get; set; }

    [Column("is_enabled")]
    public int? IsEnabled { get; set; }

    [Column("is_approval")]
    public int? IsApproval { get; set; }

    [Column("app_list_id")]
    public int? AppListId { get; set; }
}
