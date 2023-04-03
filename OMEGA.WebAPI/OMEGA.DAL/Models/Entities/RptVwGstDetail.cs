using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwGstDetail
{
    [Column("broker_company_name")]
    [StringLength(100)]
    public string? BrokerCompanyName { get; set; }

    [Column("INV_CODE")]
    [StringLength(150)]
    public string? InvCode { get; set; }

    [Column("INV_TODATE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? InvTodate { get; set; }

    [Column("INV_NO")]
    [StringLength(150)]
    public string? InvNo { get; set; }

    [Column("INV_FROMDATE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? InvFromdate { get; set; }

    [Column("INV_AMOUNT")]
    public float? InvAmount { get; set; }
}
