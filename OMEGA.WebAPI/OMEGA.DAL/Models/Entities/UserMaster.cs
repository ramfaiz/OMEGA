using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("USER_MASTER")]
public partial class UserMaster
{
    [Key]
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
    public bool? IsAdminUser { get; set; }

    [Column("is_guest_user")]
    public bool? IsGuestUser { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [Column("theme_preference")]
    [StringLength(10)]
    public string? ThemePreference { get; set; }

    [Column("language_preference")]
    public short? LanguagePreference { get; set; }

    [Column("access_level")]
    public short? AccessLevel { get; set; }

    [Column("user_legacyid")]
    [StringLength(500)]
    public string? UserLegacyid { get; set; }

    [Column("user_forgot_pwd_question")]
    [StringLength(500)]
    public string? UserForgotPwdQuestion { get; set; }

    [Column("user_forgot_pwd_answer")]
    [StringLength(500)]
    public string? UserForgotPwdAnswer { get; set; }

    [Column("user_forgot_pwd_resetkey")]
    [StringLength(500)]
    public string? UserForgotPwdResetkey { get; set; }

    [Column("user_forgot_pwd_emailrefno")]
    public long? UserForgotPwdEmailrefno { get; set; }

    [Column("user_last_loginip")]
    [StringLength(250)]
    public string? UserLastLoginip { get; set; }

    [Column("is_first_time_login")]
    public bool? IsFirstTimeLogin { get; set; }
}
