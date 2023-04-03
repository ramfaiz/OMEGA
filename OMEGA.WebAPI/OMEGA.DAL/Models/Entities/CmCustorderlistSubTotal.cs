using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_sub_Totals")]
public partial class CmCustorderlistSubTotal
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    public int? Total { get; set; }

    [Column("update_time", TypeName = "datetime")]
    public DateTime? UpdateTime { get; set; }
}
