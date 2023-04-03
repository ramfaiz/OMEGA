using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwAutoBpoHistory
{
    [Column("auto_bpo_status_desc")]
    [StringLength(50)]
    public string? AutoBpoStatusDesc { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("auto_bpo_status_id")]
    public int? AutoBpoStatusId { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("UpdatedBy")]
    [StringLength(101)]
    public string? UpdatedBy1 { get; set; }
}
