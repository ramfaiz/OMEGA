using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwCurrentUserRole
{
    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("module_id")]
    public int? ModuleId { get; set; }

    [Column("module_name")]
    [StringLength(240)]
    public string? ModuleName { get; set; }

    [Column("sub_module_id")]
    public int? SubModuleId { get; set; }

    [Column("sub_module_name")]
    [StringLength(240)]
    public string? SubModuleName { get; set; }

    [Column("permission_id")]
    public int? PermissionId { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_enabled")]
    public int? IsEnabled { get; set; }
}
