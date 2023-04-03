using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwUser
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

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("password_reset_interval")]
    public int? PasswordResetInterval { get; set; }

    [Column("password_expiry")]
    public bool? PasswordExpiry { get; set; }

    [Column("password_expiry_date", TypeName = "datetime")]
    public DateTime? PasswordExpiryDate { get; set; }

    [Column("user_status")]
    public bool? UserStatus { get; set; }

    [Column("company_code")]
    public long? CompanyCode { get; set; }

    [Column("station_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string? StationCode { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("delete_status")]
    public int? DeleteStatus { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("is_admin_user")]
    [StringLength(3)]
    [Unicode(false)]
    public string? IsAdminUser { get; set; }

    [Column("is_guest_user")]
    [StringLength(3)]
    [Unicode(false)]
    public string? IsGuestUser { get; set; }

    [Column("active_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ActiveDate { get; set; }

    [Column("inactive_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? InactiveDate { get; set; }
}
