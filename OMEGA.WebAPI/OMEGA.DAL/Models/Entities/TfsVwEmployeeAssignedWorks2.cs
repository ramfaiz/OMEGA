using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwEmployeeAssignedWorks2
{
    [StringLength(101)]
    public string? EmployeeName { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("total_count")]
    public int? TotalCount { get; set; }

    [Column("Client_Count")]
    [StringLength(100)]
    public string? ClientCount { get; set; }

    [Column("count_11")]
    public int? Count11 { get; set; }

    [Column("count_1")]
    public int? Count1 { get; set; }

    [Column("count_4")]
    public int? Count4 { get; set; }

    [Column("count_6")]
    public int? Count6 { get; set; }

    [Column("count_8")]
    public int? Count8 { get; set; }

    [Column("location")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("insp")]
    public int? Insp { get; set; }
}
