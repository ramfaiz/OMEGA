using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("PRIORITY_TIER_MAPPING")]
public partial class PriorityTierMapping
{
    [Column("priority_tier_id")]
    public short? PriorityTierId { get; set; }

    [Column("priority_order_id")]
    public short? PriorityOrderId { get; set; }

    [Column("priority_order_desc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? PriorityOrderDesc { get; set; }

    [Column("priority_due_date_type")]
    public short? PriorityDueDateType { get; set; }

    [Column("priority_due_date_type_desc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? PriorityDueDateTypeDesc { get; set; }

    [Column("priority_picture_status")]
    public short? PriorityPictureStatus { get; set; }

    [Column("priority_cust_rating")]
    public short? PriorityCustRating { get; set; }

    [Column("priority_order_urgency")]
    public short? PriorityOrderUrgency { get; set; }

    [Column("priority_order_priority")]
    public short? PriorityOrderPriority { get; set; }
}
