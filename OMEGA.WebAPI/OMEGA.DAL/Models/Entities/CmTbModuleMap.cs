using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("MenuId", "ModuleId", "SubModuleId")]
[Table("CM_TB_MODULE_MAP")]
public partial class CmTbModuleMap
{
    [Key]
    [Column("menu_id")]
    public int MenuId { get; set; }

    [Key]
    [Column("module_id")]
    public int ModuleId { get; set; }

    [Key]
    [Column("sub_module_id")]
    public int SubModuleId { get; set; }

    [Column("actual_module_id")]
    public int? ActualModuleId { get; set; }
}
