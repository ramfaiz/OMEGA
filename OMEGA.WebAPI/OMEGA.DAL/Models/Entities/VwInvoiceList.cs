﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwInvoiceList
{
    [Column("INV_ID")]
    public int InvId { get; set; }

    [Column("INV_CODE")]
    [StringLength(150)]
    public string? InvCode { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(100)]
    public string? CmCustomerName { get; set; }

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

    [Column("CUSTOMER_ID")]
    public int CustomerId { get; set; }

    [Column("payment_type")]
    public int? PaymentType { get; set; }

    [Column("company_id")]
    public int? CompanyId { get; set; }

    [Column("ref1_email_id")]
    [StringLength(500)]
    public string? Ref1EmailId { get; set; }

    [Column("is_bts")]
    public int? IsBts { get; set; }

    [Column("is_SMS")]
    public int? IsSms { get; set; }
}
