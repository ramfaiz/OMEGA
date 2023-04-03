using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("StatusReasonId", "StatusId")]
[Table("STATUS_REASON_MAP")]
public partial class StatusReasonMap
{
    [Key]
    [Column("status_reason_id")]
    public short StatusReasonId { get; set; }

    [Key]
    [Column("status_id")]
    public short StatusId { get; set; }
}
