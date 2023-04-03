using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpLeaveInfo
{
    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("year")]
    public int? Year { get; set; }

    [Column("Casual_total")]
    public double? CasualTotal { get; set; }

    [Column("Maternity_total")]
    public double? MaternityTotal { get; set; }

    [Column("Paternity_total")]
    public double? PaternityTotal { get; set; }

    [Column("CompOff_total")]
    public double? CompOffTotal { get; set; }

    [Column("gender")]
    public short? Gender { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? Branch { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }
}
