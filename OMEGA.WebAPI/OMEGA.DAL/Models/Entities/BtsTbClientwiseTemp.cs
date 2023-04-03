using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CLIENTWISE_TEMP")]
public partial class BtsTbClientwiseTemp
{
    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("client_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ClientName { get; set; }

    [Column("no_of_orders")]
    public int? NoOfOrders { get; set; }

    [Column("data_fee", TypeName = "numeric(18, 2)")]
    public decimal? DataFee { get; set; }

    [Column("is_paid")]
    [StringLength(10)]
    [Unicode(false)]
    public string? IsPaid { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }

    [Column("order_type")]
    [StringLength(20)]
    public string? OrderType { get; set; }

    [Column("total_fee", TypeName = "numeric(18, 2)")]
    public decimal? TotalFee { get; set; }
}
