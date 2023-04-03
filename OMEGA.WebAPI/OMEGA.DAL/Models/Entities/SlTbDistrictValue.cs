using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("DmDistrictId", "LanguageCode")]
[Table("SL_TB_DISTRICT_VALUES")]
public partial class SlTbDistrictValue
{
    [Key]
    [Column("DM_DISTRICT_ID")]
    public int DmDistrictId { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [ForeignKey("DmDistrictId")]
    [InverseProperty("SlTbDistrictValues")]
    public virtual SlTbDistrictMaster DmDistrict { get; set; } = null!;
}
