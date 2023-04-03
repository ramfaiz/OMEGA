using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwClientOrderSummary
{
    public int? TotalOrder { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    public int TotalAss { get; set; }

    public int TotalUnAss { get; set; }

    public int FreshOrder { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }
}
