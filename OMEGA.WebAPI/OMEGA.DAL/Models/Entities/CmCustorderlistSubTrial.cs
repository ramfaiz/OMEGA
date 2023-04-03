using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_sub_Trial")]
public partial class CmCustorderlistSubTrial
{
    [Column("CM_CUSTOMER_ID")]
    public int? CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    public string? CmCustomerName { get; set; }

    [Column("FRESH_ORDERS_7")]
    public int? FreshOrders7 { get; set; }

    [Column("PAST_DUE_ORDERS_7")]
    public int? PastDueOrders7 { get; set; }

    [Column("DUE_ORDERS_7")]
    public int? DueOrders7 { get; set; }

    [Column("INTERIOR_ORDERS_7")]
    public int? InteriorOrders7 { get; set; }

    [Column("FRESH_ORDERS_9")]
    public int? FreshOrders9 { get; set; }

    [Column("PAST_DUE_ORDERS_9")]
    public int? PastDueOrders9 { get; set; }

    [Column("DUE_ORDERS_9")]
    public int? DueOrders9 { get; set; }

    [Column("INTERIOR_ORDERS_9")]
    public int? InteriorOrders9 { get; set; }

    [Column("FRESH_ORDERS_12")]
    public int? FreshOrders12 { get; set; }

    [Column("PAST_DUE_ORDERS_12")]
    public int? PastDueOrders12 { get; set; }

    [Column("DUE_ORDERS_12")]
    public int? DueOrders12 { get; set; }

    [Column("INTERIOR_ORDERS_12")]
    public int? InteriorOrders12 { get; set; }

    [Column("FRESH_ORDERS_2")]
    public int? FreshOrders2 { get; set; }

    [Column("PAST_DUE_ORDERS_2")]
    public int? PastDueOrders2 { get; set; }

    [Column("DUE_ORDERS_2")]
    public int? DueOrders2 { get; set; }

    [Column("INTERIOR_ORDERS_2")]
    public int? InteriorOrders2 { get; set; }

    [Column("FRESH_ORDERS_4")]
    public int? FreshOrders4 { get; set; }

    [Column("PAST_DUE_ORDERS_4")]
    public int? PastDueOrders4 { get; set; }

    [Column("DUE_ORDERS_4")]
    public int? DueOrders4 { get; set; }

    [Column("INTERIOR_ORDERS_4")]
    public int? InteriorOrders4 { get; set; }

    [Column("FRESH_ORDERS_6")]
    public int? FreshOrders6 { get; set; }

    [Column("PAST_DUE_ORDERS_6")]
    public int? PastDueOrders6 { get; set; }

    [Column("DUE_ORDERS_6")]
    public int? DueOrders6 { get; set; }

    [Column("INTERIOR_ORDERS_6")]
    public int? InteriorOrders6 { get; set; }

    [Column("EMP_REF_NO")]
    public int? EmpRefNo { get; set; }
}
