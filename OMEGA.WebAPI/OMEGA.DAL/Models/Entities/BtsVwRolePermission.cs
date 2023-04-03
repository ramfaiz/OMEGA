using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwRolePermission
{
    [Column("role_id")]
    public long RoleId { get; set; }

    [Column("role_name")]
    [StringLength(500)]
    public string? RoleName { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("sub_module_id")]
    public int SubModuleId { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }
}
