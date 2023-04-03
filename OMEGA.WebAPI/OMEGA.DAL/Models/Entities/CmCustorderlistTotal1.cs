using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_Totals")]
public partial class CmCustorderlistTotal1
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    public int? Total { get; set; }

    [Column("update_time", TypeName = "datetime")]
    public DateTime? UpdateTime { get; set; }
}
