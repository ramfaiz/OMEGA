using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_RPT_PORTAL_TEMP")]
public partial class BtsTbRptPortalTemp
{
    [Column("order_no")]
    public long OrderNo { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("portal_name")]
    [StringLength(300)]
    public string? PortalName { get; set; }

    [Column("order_posted_by")]
    public long? OrderPostedBy { get; set; }

    [Column("No_Of_Orders")]
    public long? NoOfOrders { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
