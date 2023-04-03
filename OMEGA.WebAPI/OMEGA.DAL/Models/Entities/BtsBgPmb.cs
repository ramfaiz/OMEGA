using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_PMB")]
public partial class BtsBgPmb
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("OrderID")]
    public long? OrderId { get; set; }

    public long? PostedTo { get; set; }

    public long? PostedFrom { get; set; }

    [Unicode(false)]
    public string? Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dat { get; set; }

    public byte? Status { get; set; }
}
