using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmployeeOrderPriorityDetail
{
    [Column("customer_id")]
    public long? CustomerId { get; set; }

    [Column("priority_type_id")]
    public byte? PriorityTypeId { get; set; }

    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("CM_CUSTOMER_SIZE")]
    public byte? CmCustomerSize { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Rating { get; set; }

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("CM_CUSTOMER_ID")]
    public int CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Priority { get; set; }
}
