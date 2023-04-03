using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SHIFT_MASTER")]
public partial class ShiftMaster
{
    [Key]
    [Column("shift_id")]
    public long ShiftId { get; set; }

    [Column("shift_name")]
    [StringLength(500)]
    public string? ShiftName { get; set; }

    [Column("shift_start_time")]
    public TimeSpan? ShiftStartTime { get; set; }

    [Column("shift_end_time")]
    public TimeSpan? ShiftEndTime { get; set; }

    [Column("is_night")]
    public byte? IsNight { get; set; }

    [Column("amount", TypeName = "numeric(18, 0)")]
    public decimal? Amount { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
