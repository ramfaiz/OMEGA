using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TIMECLOCK_MASTER")]
public partial class TimeclockMaster
{
    [Key]
    [Column("timeclock_id")]
    public long TimeclockId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("emp_org_id")]
    public long? EmpOrgId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("session_id")]
    public long? SessionId { get; set; }

    [Column("loggedin_status")]
    public byte? LoggedinStatus { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }

    [Column("logged_in_time")]
    public TimeSpan? LoggedInTime { get; set; }

    [Column("logged_out_time")]
    public TimeSpan? LoggedOutTime { get; set; }

    [Column("Total_hours_worked")]
    public TimeSpan? TotalHoursWorked { get; set; }

    [Column("Total_hours_break")]
    public TimeSpan? TotalHoursBreak { get; set; }

    [Column("Shift_id")]
    public byte? ShiftId { get; set; }

    [Column("login_ip")]
    public string? LoginIp { get; set; }
}
