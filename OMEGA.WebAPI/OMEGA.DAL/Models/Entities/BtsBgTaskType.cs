using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_TaskTypes")]
public partial class BtsBgTaskType
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TaskName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Abbreviation { get; set; }

    public double? Fee { get; set; }

    public byte? Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dat { get; set; }
}
