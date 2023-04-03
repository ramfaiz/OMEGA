using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_WEEKLY_ORDER_TEMP")]
public partial class BtsTbWeeklyOrderTemp
{
    [Column("order_start_date", TypeName = "date")]
    public DateTime? OrderStartDate { get; set; }

    [Column("order_end_date", TypeName = "date")]
    public DateTime? OrderEndDate { get; set; }

    [Column("no_of_orders")]
    public int? NoOfOrders { get; set; }
}
