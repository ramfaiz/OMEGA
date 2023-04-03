using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("STATUS_REASON_REF")]
[Index("StatusReasonId", Name = "index_name_sr")]
public partial class StatusReasonRef
{
    [Key]
    [Column("status_reason_id")]
    public short StatusReasonId { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("next_status_reason_id")]
    public byte? NextStatusReasonId { get; set; }

    [Column("is_completed")]
    public byte? IsCompleted { get; set; }
}
