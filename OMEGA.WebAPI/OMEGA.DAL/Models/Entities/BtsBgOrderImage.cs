using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_OrderImages")]
public partial class BtsBgOrderImage
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("OrderID")]
    public long? OrderId { get; set; }

    [Unicode(false)]
    public string? Image { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? ImageName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ImageExtension { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedDate { get; set; }

    public long? UpdatedBy { get; set; }
}
