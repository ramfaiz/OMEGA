using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwCurrentUserDet
{
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("user_name")]
    [StringLength(50)]
    public string? UserName { get; set; }

    [Column("password")]
    [StringLength(50)]
    public string? Password { get; set; }

    [Column("employee_id")]
    public long? EmployeeId { get; set; }

    [Column("timeclock_id")]
    public long TimeclockId { get; set; }

    [Column("timecard_id")]
    public long TimecardId { get; set; }
}
