using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class CmVwCurrentUserDetail
{
    [Column("session_id")]
    public long? SessionId { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("user_name")]
    [StringLength(50)]
    public string? UserName { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_first_name")]
    [StringLength(100)]
    public string? EmpFirstName { get; set; }

    [Column("loggedin_status")]
    public byte? LoggedinStatus { get; set; }

    [Column("logged_in_time")]
    public TimeSpan? LoggedInTime { get; set; }

    [Column("logged_out_time")]
    public TimeSpan? LoggedOutTime { get; set; }

    [Column("timecard_id")]
    public long TimecardId { get; set; }

    [Column("clock_in")]
    public TimeSpan? ClockIn { get; set; }

    [Column("clock_out")]
    public TimeSpan? ClockOut { get; set; }

    [Column("hours_worked")]
    public TimeSpan? HoursWorked { get; set; }

    [Column("Total_hours_worked")]
    public TimeSpan? TotalHoursWorked { get; set; }

    [Column("Total_hours_break")]
    public TimeSpan? TotalHoursBreak { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }
}
