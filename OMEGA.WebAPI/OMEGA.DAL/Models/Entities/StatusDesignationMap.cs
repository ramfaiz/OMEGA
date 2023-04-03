using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("DesignationId", "StatusId")]
[Table("STATUS_DESIGNATION_MAP")]
public partial class StatusDesignationMap
{
    [Key]
    [Column("designation_id")]
    public short DesignationId { get; set; }

    [Key]
    [Column("status_id")]
    public short StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }
}
