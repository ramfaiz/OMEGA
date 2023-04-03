using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_MONTHLY_ORDER_TEMP")]
public partial class BtsTbMonthlyOrderTemp
{
    [Column("order_month")]
    public int? OrderMonth { get; set; }

    [Column("order_year")]
    public int? OrderYear { get; set; }

    [Column("no_of_orders")]
    public int? NoOfOrders { get; set; }
}
