using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmploymentHistory
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [StringLength(240)]
    public string? Department { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("history_date", TypeName = "date")]
    public DateTime? HistoryDate { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }
}
