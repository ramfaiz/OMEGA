using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CLIENT_ORDER_SUMMARY")]
public partial class ClientOrderSummary
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

    [Column("ASSIGNED_ORDERS")]
    public int? AssignedOrders { get; set; }

    [Column("UNASSIGNED_ORDERS")]
    public int? UnassignedOrders { get; set; }

    [Column("language_code")]
    public byte? LanguageCode { get; set; }

    [Column("PENDING_ORDERS")]
    public int? PendingOrders { get; set; }
}
