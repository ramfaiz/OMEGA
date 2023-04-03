using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_CompanyDetails")]
public partial class BtsBgCompanyDetail
{
    [Key]
    [Column("CompanyID")]
    public long CompanyId { get; set; }

    [Column("MainUserID")]
    public long? MainUserId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    public long? AddedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AddedDat { get; set; }
}
