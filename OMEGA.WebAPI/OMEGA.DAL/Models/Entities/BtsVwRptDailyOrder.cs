using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwRptDailyOrder
{
    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("portal_name")]
    [StringLength(300)]
    public string? PortalName { get; set; }

    [Column("No_Of_Orders")]
    public int? NoOfOrders { get; set; }

    [Column("order_posted_by")]
    public long? OrderPostedBy { get; set; }
}
