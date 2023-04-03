using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_OrderLogs")]
public partial class BtsBgOrderLog
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Type { get; set; }

    public long? UpdatedBy { get; set; }

    [Unicode(false)]
    public string? Log { get; set; }

    [Column("OrderIDs")]
    [Unicode(false)]
    public string? OrderIds { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
