using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("EmEmirateId", "LanguageCode")]
[Table("SL_TB_EMIRATE_VALUES")]
public partial class SlTbEmirateValue
{
    [Key]
    [Column("EM_EMIRATE_ID")]
    public int EmEmirateId { get; set; }

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

    [ForeignKey("EmEmirateId")]
    [InverseProperty("SlTbEmirateValues")]
    public virtual SlTbEmirateMaster EmEmirate { get; set; } = null!;
}
