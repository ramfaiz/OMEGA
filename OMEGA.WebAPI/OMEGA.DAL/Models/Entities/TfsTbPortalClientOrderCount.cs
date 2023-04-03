using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_PORTAL_CLIENT_ORDER_COUNT")]
public partial class TfsTbPortalClientOrderCount
{
    [Column("client_id")]
    public int? ClientId { get; set; }

    [Column("portal_id")]
    public int? PortalId { get; set; }

    [Column("client_name")]
    [StringLength(50)]
    public string? ClientName { get; set; }

    [Column("Order_count")]
    public int? OrderCount { get; set; }
}
