using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("ModuleId", "LanguageCode")]
[Table("MODULE_VALUES")]
public partial class ModuleValue
{
    [Key]
    [Column("module_id")]
    public int ModuleId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(240)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("ModuleValues")]
    public virtual ModulesRef Module { get; set; } = null!;
}
