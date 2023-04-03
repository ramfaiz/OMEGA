using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TIMECLOCK_DETAIL")]
public partial class TimeclockDetail
{
    [Key]
    [Column("timecard_id")]
    public long TimecardId { get; set; }

    [Column("timeclock_id")]
    public long? TimeclockId { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("emp_org_id")]
    public long? EmpOrgId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }

    [Column("clock_in")]
    public TimeSpan? ClockIn { get; set; }

    [Column("clock_out")]
    public TimeSpan? ClockOut { get; set; }

    [Column("hours_worked")]
    public TimeSpan? HoursWorked { get; set; }

    [Column("is_manual_adjust")]
    public int? IsManualAdjust { get; set; }

    [Column("last_updated_by")]
    public short? LastUpdatedBy { get; set; }

    [Column("last_updated_date", TypeName = "date")]
    public DateTime? LastUpdatedDate { get; set; }

    [Column("trans_status")]
    public byte? TransStatus { get; set; }
}
