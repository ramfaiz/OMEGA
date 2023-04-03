using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("RPT_EMPWISE_QC_TEMP")]
public partial class RptEmpwiseQcTemp
{
    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("empcode")]
    [StringLength(50)]
    public string? Empcode { get; set; }

    [Column("employeename")]
    public string? Employeename { get; set; }

    [Column("location")]
    [StringLength(500)]
    public string? Location { get; set; }

    [Column("company_id")]
    public long? CompanyId { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }

    [Column("designation_id")]
    public long? DesignationId { get; set; }

    [Column("designation")]
    [StringLength(500)]
    public string? Designation { get; set; }

    [Column("orderId")]
    public long? OrderId { get; set; }

    [Column("qc_date", TypeName = "date")]
    public DateTime? QcDate { get; set; }

    [Column("order_type")]
    [StringLength(500)]
    public string? OrderType { get; set; }

    [Column("client_name")]
    public string? ClientName { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("orderdate", TypeName = "date")]
    public DateTime? Orderdate { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("issue_by")]
    public string? IssueBy { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }
}
