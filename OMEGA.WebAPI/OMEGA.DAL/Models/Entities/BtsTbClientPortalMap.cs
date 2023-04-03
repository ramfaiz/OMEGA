using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_CLIENT_PORTAL_MAP")]
[Index("ClientId", Name = "missing_index_124_123_BTS_TB_CLIENT_PORTAL_MAP")]
[Index("ClientId", Name = "missing_index_130_129_BTS_TB_CLIENT_PORTAL_MAP")]
[Index("ClientId", "PortalId", Name = "missing_index_8256_8255_BTS_TB_CLIENT_PORTAL_MAP")]
[Index("ClientId", Name = "missing_index_924_923_BTS_TB_CLIENT_PORTAL_MAP")]
public partial class BtsTbClientPortalMap
{
    [Key]
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("order_int_value", TypeName = "numeric(18, 2)")]
    public decimal? OrderIntValue { get; set; }

    [Column("order_ext_value", TypeName = "numeric(18, 2)")]
    public decimal? OrderExtValue { get; set; }
}
