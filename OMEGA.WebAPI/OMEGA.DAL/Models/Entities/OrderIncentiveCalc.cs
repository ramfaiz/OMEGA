using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("ORDER_INCENTIVE_CALC")]
public partial class OrderIncentiveCalc
{
    [Key]
    [Column("slab_ref_no")]
    public long SlabRefNo { get; set; }

    [Column("desig_id")]
    public int? DesigId { get; set; }

    [Column("task_type")]
    public short? TaskType { get; set; }

    [Column("min_order_count")]
    public int? MinOrderCount { get; set; }

    [Column("start_range")]
    public int? StartRange { get; set; }

    [Column("end_range")]
    public int? EndRange { get; set; }

    [Column("avg_ord_count")]
    public int? AvgOrdCount { get; set; }

    [Column("rate")]
    public int? Rate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
