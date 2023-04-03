using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("OWNING_COST_CTR_REF")]
public partial class OwningCostCtrRef
{
    [Key]
    [Column("owning_cost_ctr")]
    public short OwningCostCtr { get; set; }

    [Column("is_default")]
    public byte IsDefault { get; set; }

    [InverseProperty("OwningCostCtrNavigation")]
    public virtual ICollection<OwningCostCtrValue> OwningCostCtrValues { get; } = new List<OwningCostCtrValue>();
}
