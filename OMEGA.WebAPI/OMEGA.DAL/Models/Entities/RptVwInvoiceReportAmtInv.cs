using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwInvoiceReportAmtInv
{
    [Column("INV_CODE")]
    [StringLength(150)]
    public string? InvCode { get; set; }

    [Column("INV_AMOUNT")]
    public float? InvAmount { get; set; }

    [Column("REMARKS")]
    [StringLength(150)]
    public string? Remarks { get; set; }

    [Column("INV_FROMDATE", TypeName = "datetime")]
    public DateTime? InvFromdate { get; set; }

    [Column("INV_TODATE", TypeName = "datetime")]
    public DateTime? InvTodate { get; set; }

    [Column("CREATEDDATE", TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("CUSTOMER_ID")]
    public int CustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(100)]
    public string? CmCustomerName { get; set; }

    [Column("CM_ADDRESS1")]
    public string? CmAddress1 { get; set; }

    [Column("ORDER_TYPE_NAME")]
    [StringLength(150)]
    public string? OrderTypeName { get; set; }

    [Column("ORDER_UNIT_AMOUNT")]
    public float? OrderUnitAmount { get; set; }

    [Column("ORDER_TYPE_COUNT")]
    public int? OrderTypeCount { get; set; }

    [Column("ORDER_TYPE_AMOUNT")]
    public float? OrderTypeAmount { get; set; }

    [Column("CM_ADDRESS2")]
    public string? CmAddress2 { get; set; }

    [Column("INV_NO")]
    [StringLength(150)]
    public string? InvNo { get; set; }
}
