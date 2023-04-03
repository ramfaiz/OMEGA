using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_SUBMISSION")]
public partial class CmCustorderlistSubmission
{
    [Column("CM_CUSTOMER_ID")]
    public int? CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    public string? CmCustomerName { get; set; }

    [Column("FRESH_ORDERS")]
    public int? FreshOrders { get; set; }

    [Column("PAST_DUE_ORDERS")]
    public int? PastDueOrders { get; set; }

    [Column("DUE_ORDERS")]
    public int? DueOrders { get; set; }

    [Column("INTERIOR_ORDERS")]
    public int? InteriorOrders { get; set; }

    [Column("EMP_REF_NO")]
    public int? EmpRefNo { get; set; }
}
