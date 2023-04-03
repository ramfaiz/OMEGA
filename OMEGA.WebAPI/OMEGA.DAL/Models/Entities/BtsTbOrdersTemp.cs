using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_ORDERS_TEMP")]
public partial class BtsTbOrdersTemp
{
    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("order_month")]
    public int? OrderMonth { get; set; }

    [Column("order_year")]
    public int? OrderYear { get; set; }
}
