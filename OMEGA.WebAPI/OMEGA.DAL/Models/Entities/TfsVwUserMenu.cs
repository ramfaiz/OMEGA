using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwUserMenu
{
    [Column("module_id")]
    public long? ModuleId { get; set; }

    [Column("display_value")]
    [StringLength(50)]
    public string? DisplayValue { get; set; }

    [Column("module_image_class")]
    public string? ModuleImageClass { get; set; }

    [Column("sub_display_value")]
    [StringLength(500)]
    public string? SubDisplayValue { get; set; }

    [Column("sub_module_src")]
    public string? SubModuleSrc { get; set; }

    [Column("role_id")]
    public long? RoleId { get; set; }

    [Column("sub_module_id")]
    public long? SubModuleId { get; set; }

    [Column("is_active")]
    public long? IsActive { get; set; }

    [Column("list_priority")]
    public long? ListPriority { get; set; }
}
