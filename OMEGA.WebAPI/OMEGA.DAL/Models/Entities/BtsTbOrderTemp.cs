using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_ORDER_TEMP")]
public partial class BtsTbOrderTemp
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
}
