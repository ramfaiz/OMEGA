using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_Trial")]
public partial class CmCustorderlistTrial
{
    [Column("CM_CUSTOMER_ID")]
    public int? CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    public string? CmCustomerName { get; set; }

    public int? Total { get; set; }

    [Column("NEW_ORDERS_7")]
    public int? NewOrders7 { get; set; }

    [Column("DE_ORDERS_7")]
    public int? DeOrders7 { get; set; }

    [Column("DUE_ORDERS_7")]
    public int? DueOrders7 { get; set; }

    [Column("NEW_ORDERS_9")]
    public int? NewOrders9 { get; set; }

    [Column("DE_ORDERS_9")]
    public int? DeOrders9 { get; set; }

    [Column("DUE_ORDERS_9")]
    public int? DueOrders9 { get; set; }

    [Column("NEW_ORDERS_12")]
    public int? NewOrders12 { get; set; }

    [Column("DE_ORDERS_12")]
    public int? DeOrders12 { get; set; }

    [Column("DUE_ORDERS_12")]
    public int? DueOrders12 { get; set; }

    [Column("NEW_ORDERS_2")]
    public int? NewOrders2 { get; set; }

    [Column("DE_ORDERS_2")]
    public int? DeOrders2 { get; set; }

    [Column("DUE_ORDERS_2")]
    public int? DueOrders2 { get; set; }

    [Column("NEW_ORDERS_4")]
    public int? NewOrders4 { get; set; }

    [Column("DE_ORDERS_4")]
    public int? DeOrders4 { get; set; }

    [Column("DUE_ORDERS_4")]
    public int? DueOrders4 { get; set; }

    [Column("NEW_ORDERS_6")]
    public int? NewOrders6 { get; set; }

    [Column("DE_ORDERS_6")]
    public int? DeOrders6 { get; set; }

    [Column("DUE_ORDERS_6")]
    public int? DueOrders6 { get; set; }
}
