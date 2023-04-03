using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwLeaveReport
{
    [Column("leave_ref_no")]
    public long LeaveRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("leave_start_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? LeaveStartDate { get; set; }

    [Column("leave_end_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? LeaveEndDate { get; set; }

    [Column("leave_days", TypeName = "numeric(18, 1)")]
    public decimal? LeaveDays { get; set; }

    [Column("entry_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? EntryDate { get; set; }

    [Column("leave_remarks")]
    [StringLength(240)]
    public string? LeaveRemarks { get; set; }

    [Column("leave_status")]
    [StringLength(8)]
    [Unicode(false)]
    public string? LeaveStatus { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("department")]
    [StringLength(240)]
    public string? Department { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("leave_type")]
    [StringLength(200)]
    public string? LeaveType { get; set; }
}
