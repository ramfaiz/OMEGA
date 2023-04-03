using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("CUST_ORDER_COUNT_TEMP")]
public partial class CustOrderCountTemp
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("total_fresh")]
    public int? TotalFresh { get; set; }

    [Column("total_entry")]
    public int? TotalEntry { get; set; }

    [Column("total_due")]
    public int? TotalDue { get; set; }

    [Column("total_revision")]
    public int? TotalRevision { get; set; }
}
