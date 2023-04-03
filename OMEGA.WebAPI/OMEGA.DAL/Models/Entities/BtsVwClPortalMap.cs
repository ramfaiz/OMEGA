using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwClPortalMap
{
    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("portal_id")]
    public long PortalId { get; set; }

    [Column("portal_code")]
    public string? PortalCode { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("portal_int_value", TypeName = "numeric(18, 2)")]
    public decimal? PortalIntValue { get; set; }

    [Column("portal_ext_value", TypeName = "numeric(18, 2)")]
    public decimal? PortalExtValue { get; set; }

    [Column("is_checked")]
    public int IsChecked { get; set; }
}
