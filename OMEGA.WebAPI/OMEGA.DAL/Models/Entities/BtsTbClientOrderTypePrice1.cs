using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CLIENT_ORDER_TYPE_PRICE_1")]
public partial class BtsTbClientOrderTypePrice1
{
    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("order_type_id")]
    public int? OrderTypeId { get; set; }

    [Column("order_type")]
    [StringLength(150)]
    public string? OrderType { get; set; }

    [Column("price")]
    public float? Price { get; set; }
}
