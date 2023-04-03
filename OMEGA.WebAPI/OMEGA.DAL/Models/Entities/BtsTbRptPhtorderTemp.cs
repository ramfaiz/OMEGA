using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_RPT_PHTORDER_TEMP")]
public partial class BtsTbRptPhtorderTemp
{
    [Column("pht_id")]
    public long? PhtId { get; set; }

    [Column("pht_name")]
    public string? PhtName { get; set; }

    [Column("order_no")]
    public long OrderNo { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("pcity_id")]
    public long? PcityId { get; set; }

    [Column("pcity_name")]
    [StringLength(300)]
    public string? PcityName { get; set; }

    [Column("pstate_id")]
    public long? PstateId { get; set; }

    [Column("pstate_name")]
    [StringLength(300)]
    public string? PstateName { get; set; }

    [Column("order_posted_by")]
    public long? OrderPostedBy { get; set; }

    [Column("No_Of_Orders")]
    public long? NoOfOrders { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
