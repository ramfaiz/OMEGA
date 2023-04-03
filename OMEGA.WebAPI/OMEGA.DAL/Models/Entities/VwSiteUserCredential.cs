using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwSiteUserCredential
{
    public string? SiteDesc { get; set; }

    [StringLength(500)]
    public string? UserName { get; set; }

    [StringLength(500)]
    public string? Password { get; set; }

    [Column("emp_name")]
    [StringLength(101)]
    public string EmpName { get; set; } = null!;

    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [Column("status")]
    public byte? Status { get; set; }

    [Column("date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("is_reassign")]
    public byte? IsReassign { get; set; }

    [StringLength(500)]
    public string? Url { get; set; }
}
