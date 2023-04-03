using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwOrdStatusCheck
{
    [Column("status_id")]
    public short StatusId { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("is_status_completed")]
    public byte? IsStatusCompleted { get; set; }

    [Column("is_submitted")]
    public byte? IsSubmitted { get; set; }

    [Column("status_reason_id")]
    public short StatusReasonId { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("is_status_reason_completed")]
    public byte? IsStatusReasonCompleted { get; set; }
}
