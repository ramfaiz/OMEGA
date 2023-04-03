using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_EMPLOYEE_WORK_ASSIGNED_1")]
public partial class TfsTbEmployeeWorkAssigned1
{
    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("total_count")]
    public int? TotalCount { get; set; }

    [Column("ins")]
    public int? Ins { get; set; }

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
}
