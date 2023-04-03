using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_ContactUS")]
public partial class BtsBgContactU
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Unicode(false)]
    public string? Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AddedDate { get; set; }

    [Column("IP")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Ip { get; set; }
}
