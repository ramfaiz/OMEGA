using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_ClientDetails")]
public partial class BtsBgClientDetail
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UserKey { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? State { get; set; }

    public bool? Verified { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CellPhone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CellCarrier { get; set; }

    [Column("MainUserID")]
    public long? MainUserId { get; set; }

    public byte? MemType { get; set; }

    [Column("RoleID")]
    public byte? RoleId { get; set; }

    [Column("TFSUserID")]
    public long? TfsuserId { get; set; }

    public bool? IsDefault { get; set; }
}
