using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_USER_MASTER")]
[Index("UserId", Name = "UQ__BTS_TB_U__B9BE370E0F61B33C_1", IsUnique = true)]
[Index("Username", Name = "UQ__BTS_TB_U__F3DBC572D174CC3D_1", IsUnique = true)]
public partial class BtsTbUserMaster
{
    [Key]
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("ref_no")]
    public long? RefNo { get; set; }

    [Column("username")]
    [StringLength(500)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(500)]
    public string? Password { get; set; }

    [Column("password_hint")]
    [StringLength(500)]
    public string? PasswordHint { get; set; }

    [Column("password_expiry", TypeName = "datetime")]
    public DateTime? PasswordExpiry { get; set; }

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
