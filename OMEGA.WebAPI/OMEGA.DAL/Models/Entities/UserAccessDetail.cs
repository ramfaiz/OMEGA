using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("USER_ACCESS_DETAIL")]
public partial class UserAccessDetail
{
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("emp_id")]
    public long EmpId { get; set; }

    [Column("location_id")]
    public int? LocationId { get; set; }

    [Column("station_id")]
    public int? StationId { get; set; }

    [Column("department_id")]
    public int? DepartmentId { get; set; }
}
