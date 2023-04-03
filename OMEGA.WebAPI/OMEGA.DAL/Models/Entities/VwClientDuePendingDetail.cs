using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwClientDuePendingDetail
{
    [Column("full_name")]
    [StringLength(70)]
    public string? FullName { get; set; }

    [Column("bill_amount")]
    public int? BillAmount { get; set; }

    [Column("paid_amount")]
    public int? PaidAmount { get; set; }

    [Column("due_amount")]
    public int? DueAmount { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("company_name")]
    public string? CompanyName { get; set; }

    [Column("ref1_email_id")]
    [StringLength(500)]
    public string? Ref1EmailId { get; set; }
}
