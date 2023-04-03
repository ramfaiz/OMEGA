using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_BG_OrderTasks")]
[Index("AssignTo", "AssignDate", Name = "missing_index_108_107_BTS_BG_OrderTasks")]
[Index("AssignTo", "Status", "AssignDate", Name = "missing_index_110_109_BTS_BG_OrderTasks")]
[Index("Status", "AssignTo", "AssignDate", Name = "missing_index_112_111_BTS_BG_OrderTasks")]
[Index("Status", Name = "missing_index_114_113_BTS_BG_OrderTasks")]
[Index("AssignTo", "Status", "AssignDate", Name = "missing_index_11988_11987_BTS_BG_OrderTasks")]
[Index("AssignTo", "AssignDate", Name = "missing_index_11992_11991_BTS_BG_OrderTasks")]
[Index("Status", "AssignTo", "CompletedDate", Name = "missing_index_12000_11999_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_1227_1226_BTS_BG_OrderTasks")]
[Index("MainOrderId", "AssignTo", Name = "missing_index_145_144_BTS_BG_OrderTasks")]
[Index("AssignTo", "AssignDate", Name = "missing_index_146_145_BTS_BG_OrderTasks")]
[Index("AssignTo", "Status", "AssignDate", Name = "missing_index_148_147_BTS_BG_OrderTasks")]
[Index("Status", "AssignTo", "AssignDate", Name = "missing_index_150_149_BTS_BG_OrderTasks")]
[Index("AssignTo", "AssignDate", Name = "missing_index_156_155_BTS_BG_OrderTasks")]
[Index("AssignTo", "AssignDate", Name = "missing_index_173_172_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_190_189_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_28650_28649_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_31684_31683_BTS_BG_OrderTasks")]
[Index("MainOrderId", "AssignDate", Name = "missing_index_49846_49845_BTS_BG_OrderTasks")]
[Index("Status", Name = "missing_index_49856_49855_BTS_BG_OrderTasks")]
[Index("Status", Name = "missing_index_49859_49858_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_49864_49863_BTS_BG_OrderTasks")]
[Index("AssignTo", Name = "missing_index_49866_49865_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_630_629_BTS_BG_OrderTasks")]
[Index("MainOrderId", "Status", Name = "missing_index_8258_8257_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_8260_8259_BTS_BG_OrderTasks")]
[Index("MainOrderId", "Status", Name = "missing_index_9796_9795_BTS_BG_OrderTasks")]
[Index("MainOrderId", "Status", Name = "missing_index_9799_9798_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_9801_9800_BTS_BG_OrderTasks")]
[Index("MainOrderId", Name = "missing_index_99_98_BTS_BG_OrderTasks")]
public partial class BtsBgOrderTask
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("MainOrderID")]
    public long? MainOrderId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? TaskName { get; set; }

    public double? Fee { get; set; }

    public byte? Status { get; set; }

    public long? AssignTo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Abbreviation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AssignDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Dat { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Log { get; set; }

    public long? CompletedBy { get; set; }

    public bool? IsPaid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaidDate { get; set; }
}
