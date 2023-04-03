using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SESSION_MANAGEMENT")]
[Index("Ipaddress", Name = "missing_index_30_29_SESSION_MANAGEMENT")]
public partial class SessionManagement
{
    [Key]
    [Column("sessionid")]
    public int Sessionid { get; set; }

    [Column("userid")]
    public int? Userid { get; set; }

    [Column("owning_cost_id")]
    public short? OwningCostId { get; set; }

    [Column("serverid")]
    public byte Serverid { get; set; }

    [Column("connection_string")]
    [StringLength(500)]
    [Unicode(false)]
    public string ConnectionString { get; set; } = null!;

    [Column("created_datetime", TypeName = "datetime")]
    public DateTime? CreatedDatetime { get; set; }

    [Column("ipaddress")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ipaddress { get; set; }
}
