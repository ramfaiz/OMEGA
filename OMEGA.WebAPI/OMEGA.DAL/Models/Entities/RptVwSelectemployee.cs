using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwSelectemployee
{
    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("location")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("dept_name")]
    [StringLength(240)]
    public string? DeptName { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("approver_id")]
    public long? ApproverId { get; set; }
}
