using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("OwningCostCtr", "LanguageCode")]
[Table("OWNING_COST_CTR_VALUES")]
public partial class OwningCostCtrValue
{
    [Key]
    [Column("owning_cost_ctr")]
    public short OwningCostCtr { get; set; }

    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("short_display")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ShortDisplay { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    [Unicode(false)]
    public string? DisplayValue { get; set; }

    [ForeignKey("OwningCostCtr")]
    [InverseProperty("OwningCostCtrValues")]
    public virtual OwningCostCtrRef OwningCostCtrNavigation { get; set; } = null!;
}
