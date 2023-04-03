using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_CUSTORDERLIST_client_report")]
public partial class CmCustorderlistClientReport
{
    [Column("CM_CUSTOMER_ID")]
    public int? CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    public string? CmCustomerName { get; set; }

    [Column("TOTAL_ORDERS")]
    public int? TotalOrders { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }
}
