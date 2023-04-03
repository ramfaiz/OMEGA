using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwUserAccess
{
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("user_name")]
    [StringLength(50)]
    public string? UserName { get; set; }

    [Column("location_id")]
    public int? LocationId { get; set; }

    [Column("station_id")]
    public int? StationId { get; set; }

    [Column("department_id")]
    public int? DepartmentId { get; set; }

    [Column("employee_id")]
    public long? EmployeeId { get; set; }

    [Column("access_level")]
    public short? AccessLevel { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [Column("delete_status")]
    public int? DeleteStatus { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }
}
