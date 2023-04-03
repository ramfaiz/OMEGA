using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CL_PORTAL_TEMP")]
public partial class BtsTbClPortalTemp
{
    [Column("client_id")]
    public long ClientId { get; set; }

    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("portal_code")]
    public string? PortalCode { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("portal_int_value", TypeName = "numeric(18, 2)")]
    public decimal? PortalIntValue { get; set; }

    [Column("portal_ext_value", TypeName = "numeric(18, 2)")]
    public decimal? PortalExtValue { get; set; }

    [Column("is_checked")]
    public byte? IsChecked { get; set; }
}
