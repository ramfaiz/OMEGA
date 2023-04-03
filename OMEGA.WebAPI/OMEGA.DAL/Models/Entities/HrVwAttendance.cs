using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwAttendance
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("employee_name")]
    [StringLength(151)]
    public string? EmployeeName { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }

    [Column("Total_hours_worked")]
    public TimeSpan? TotalHoursWorked { get; set; }

    [Column("logged_in_time")]
    public TimeSpan? LoggedInTime { get; set; }

    [Column("logged_out_time")]
    public TimeSpan? LoggedOutTime { get; set; }

    [Column("loggedin_status")]
    public byte? LoggedinStatus { get; set; }

    [Column("timeclock_id")]
    public long? TimeclockId { get; set; }

    [Column("branch")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Branch { get; set; }
}
