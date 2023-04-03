using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_PHOTOGRAPHER_FEE")]
public partial class BtsTbPhotographerFee
{
    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("photographer_id")]
    public int? PhotographerId { get; set; }

    [Column("type_id")]
    public int? TypeId { get; set; }

    [Column("order_fee")]
    public double? OrderFee { get; set; }
}
