using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwEmpUserListEncodedUserMaster
{
    [Column("user_id")]
    [StringLength(100)]
    public string? UserId { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    public string? RefNo { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(50)]
    public string? Password { get; set; }

    [Column("password_hint")]
    [StringLength(50)]
    public string? PasswordHint { get; set; }

    [Column("password_expiry")]
    [StringLength(50)]
    public string? PasswordExpiry { get; set; }

    public long Expr1 { get; set; }

    public long? Expr2 { get; set; }

    [StringLength(500)]
    public string? Expr3 { get; set; }

    [StringLength(500)]
    public string? Expr4 { get; set; }

    [StringLength(500)]
    public string? Expr5 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Expr6 { get; set; }

    [Column("company_code")]
    public long? CompanyCode { get; set; }

    [Column("role_id")]
    public long? RoleId { get; set; }

    [Column("access_level")]
    public byte? AccessLevel { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [Column("status_id")]
    public byte? StatusId { get; set; }

    [Column("theme_preference")]
    public byte? ThemePreference { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_first_login")]
    public byte? IsFirstLogin { get; set; }
}
