using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwInvoiceList1
{
    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("INV_CODE")]
    [StringLength(150)]
    public string? InvCode { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("INV_AMOUNT")]
    public float? InvAmount { get; set; }

    [Column("INV_FROMDATE", TypeName = "datetime")]
    public DateTime? InvFromdate { get; set; }

    [Column("INV_TODATE", TypeName = "datetime")]
    public DateTime? InvTodate { get; set; }

    [Column("CREATEDDATE", TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column("INV_DUE_DDATE", TypeName = "datetime")]
    public DateTime? InvDueDdate { get; set; }

    [Column("DELETESTATUS")]
    public int? Deletestatus { get; set; }
}
