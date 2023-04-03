using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_PORTAL_ORDER_COUNT")]
public partial class TfsTbPortalOrderCount
{
    [Column("portal_id")]
    public int? PortalId { get; set; }

    [Column("portal_name")]
    [StringLength(25)]
    public string? PortalName { get; set; }

    public int? Counts { get; set; }
}
