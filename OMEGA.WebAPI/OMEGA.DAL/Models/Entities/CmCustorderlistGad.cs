using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_GAD")]
public partial class CmCustorderlistGad
{
    [Column("CM_CUSTOMER_ID")]
    public int? CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    public string? CmCustomerName { get; set; }

    [Column("NEW_ORDERS")]
    public int? NewOrders { get; set; }

    [Column("DE_ORDERS")]
    public int? DeOrders { get; set; }

    [Column("DUE_ORDERS")]
    public int? DueOrders { get; set; }

    [Column("EMP_REF_NO")]
    public int? EmpRefNo { get; set; }
}
