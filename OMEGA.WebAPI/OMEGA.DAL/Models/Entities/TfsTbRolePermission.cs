using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_ROLE_PERMISSION")]
public partial class TfsTbRolePermission
{
    [Key]
    [Column("sl_no")]
    public long SlNo { get; set; }

    [Column("permission_id")]
    public long? PermissionId { get; set; }

    [Column("role_id")]
    public long? RoleId { get; set; }

    [Column("module_id")]
    public long? ModuleId { get; set; }

    [Column("sub_module_id")]
    public long? SubModuleId { get; set; }

    [Column("is_active")]
    public long? IsActive { get; set; }
}
