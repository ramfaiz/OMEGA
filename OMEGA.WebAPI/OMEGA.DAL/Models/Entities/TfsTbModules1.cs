using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_MODULES_1")]
public partial class TfsTbModules1
{
    [Key]
    [Column("sl_no")]
    public long SlNo { get; set; }

    [Column("module_id")]
    public long? ModuleId { get; set; }

    [Column("is_active")]
    public byte? IsActive { get; set; }

    [Column("display_value")]
    [StringLength(50)]
    public string? DisplayValue { get; set; }

    [Column("module_image_class")]
    public string? ModuleImageClass { get; set; }
}
