using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("SubModuleId", "LanguageCode")]
[Table("SUB_MODULE_VALUES")]
public partial class SubModuleValue
{
    [Key]
    [Column("sub_module_id")]
    public int SubModuleId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(240)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("long_desc")]
    [StringLength(200)]
    public string? LongDesc { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [ForeignKey("SubModuleId")]
    [InverseProperty("SubModuleValues")]
    public virtual SubModulesRef SubModule { get; set; } = null!;
}
