using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class CmVwOrderslist
{
    [Column("CM_CUSTOMER_ID")]
    public int? CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    public string? CmCustomerCode { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    public string? CmCustomerName { get; set; }

    [Column("TOTAL_ORDERS")]
    public int? TotalOrders { get; set; }

    [Column("RE_ORDERS")]
    public int? ReOrders { get; set; }

    [Column("DE_ORDERS")]
    public int? DeOrders { get; set; }

    [Column("DUE_ORDERS")]
    public int? DueOrders { get; set; }

    [Column("REVISION")]
    public int? Revision { get; set; }

    [Column("TOTAL_RE")]
    public int? TotalRe { get; set; }

    [Column("TOTAL_DE")]
    public int? TotalDe { get; set; }

    [Column("TOTAL_DUE")]
    public int? TotalDue { get; set; }

    [Column("TOTAL_REV")]
    public int? TotalRev { get; set; }

    [Column("NEW_ORDER")]
    public int? NewOrder { get; set; }

    [Column("ASSIGNED_ORDER")]
    public int? AssignedOrder { get; set; }

    [Column("INPROGRESS_ORDER")]
    public int? InprogressOrder { get; set; }
}
