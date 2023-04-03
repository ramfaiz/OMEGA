using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwDailyOrderStatusEmp1
{
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("CM_CUSTOMER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerCode { get; set; } = null!;

    [Column("CM_CUSTOMER_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string CmCustomerName { get; set; } = null!;

    [Column("subject_address")]
    [StringLength(500)]
    public string? SubjectAddress { get; set; }

    [Column("state_id")]
    public short? StateId { get; set; }

    [Column("county_id")]
    public short? CountyId { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("order_type")]
    public short? OrderType { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Ordertypename { get; set; }

    [Column("language_code")]
    public short? LanguageCode { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("employee_name")]
    [StringLength(101)]
    public string? EmployeeName { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }
}
