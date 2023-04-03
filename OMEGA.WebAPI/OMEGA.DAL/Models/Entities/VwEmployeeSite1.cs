using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwEmployeeSite1
{
    [Column("ref_id")]
    public long RefId { get; set; }

    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("time")]
    public TimeSpan? Time { get; set; }

    [Column("site_name")]
    public string? SiteName { get; set; }

    public int? SiteType { get; set; }
}
