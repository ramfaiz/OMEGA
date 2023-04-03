using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("MenuId", "LanguageCode")]
[Table("MENU_VALUES")]
public partial class MenuValue
{
    [Key]
    [Column("menu_id")]
    public int MenuId { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(50)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("MenuValues")]
    public virtual MenuRef Menu { get; set; } = null!;
}
