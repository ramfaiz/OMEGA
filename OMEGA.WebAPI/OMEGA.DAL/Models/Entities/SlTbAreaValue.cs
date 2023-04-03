using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("AmAreaId", "LanguageCode")]
[Table("SL_TB_AREA_VALUES")]
public partial class SlTbAreaValue
{
    [Key]
    [Column("AM_AREA_ID")]
    public int AmAreaId { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [ForeignKey("AmAreaId")]
    [InverseProperty("SlTbAreaValues")]
    public virtual SlTbAreaMaster AmArea { get; set; } = null!;
}
