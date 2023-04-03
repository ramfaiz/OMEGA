using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYEE_ORDER_PRIORITY")]
public partial class HrTbEmployeeOrderPriority
{
    [Key]
    [Column("ord_priority_id")]
    public long OrdPriorityId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("empt_detail_ref_no")]
    public long? EmptDetailRefNo { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("customer_id")]
    public long? CustomerId { get; set; }

    [Column("priority_type_id")]
    public byte? PriorityTypeId { get; set; }
}
