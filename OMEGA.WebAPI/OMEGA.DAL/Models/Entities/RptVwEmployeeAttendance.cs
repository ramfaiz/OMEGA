using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmployeeAttendance
{
    [Column("timeclock_id")]
    public long TimeclockId { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }

    [Column("trans_date_display")]
    [StringLength(30)]
    [Unicode(false)]
    public string? TransDateDisplay { get; set; }

    [Column("Total_hours_worked")]
    public TimeSpan? TotalHoursWorked { get; set; }

    [Column("Total_hours_break")]
    public TimeSpan? TotalHoursBreak { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(101)]
    public string? EmployeeName { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("logged_in")]
    public TimeSpan? LoggedIn { get; set; }

    [Column("logged_out")]
    public TimeSpan? LoggedOut { get; set; }

    [Column("logged_in_time")]
    [StringLength(4000)]
    public string? LoggedInTime { get; set; }

    [Column("logged_out_time")]
    [StringLength(4000)]
    public string? LoggedOutTime { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }
}
