using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_StaffMaster")]
public partial class BtsBgStaffMaster
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("MainUserID")]
    public long? MainUserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [Column("RoleID")]
    public byte? RoleId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    public bool? Verified { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserKey { get; set; }

    /// <summary>
    /// 1-Active,2-Deletetd,3-InActive
    /// </summary>
    public byte? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CellPhone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CellCarrier { get; set; }
}
