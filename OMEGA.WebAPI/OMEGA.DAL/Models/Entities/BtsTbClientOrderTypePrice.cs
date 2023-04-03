using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CLIENT_ORDER_TYPE_PRICE")]
public partial class BtsTbClientOrderTypePrice
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("order_type_id")]
    public int? OrderTypeId { get; set; }

    [Column("order_type")]
    [StringLength(150)]
    public string? OrderType { get; set; }

    [Column("price")]
    public float? Price { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }
}
