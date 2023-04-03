using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_CLIENT_DUE_AMOUNT")]
public partial class TfsTbClientDueAmount
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("full_name")]
    [StringLength(70)]
    public string? FullName { get; set; }

    [Column("bill_amount")]
    public double? BillAmount { get; set; }

    [Column("paid_amount")]
    public double? PaidAmount { get; set; }

    [Column("due_amount")]
    public double? DueAmount { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
