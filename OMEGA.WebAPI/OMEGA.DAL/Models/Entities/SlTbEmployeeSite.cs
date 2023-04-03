using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_EMPLOYEE_SITE")]
public partial class SlTbEmployeeSite
{
    [Key]
    [Column("ref_id")]
    public long RefId { get; set; }

    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("time")]
    public TimeSpan? Time { get; set; }

    [Column("status")]
    public byte? Status { get; set; }

    [Column("is_reassign")]
    public byte? IsReassign { get; set; }
}
