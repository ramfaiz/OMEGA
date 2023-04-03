using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_RPT_EMPWISE_TRACKING_TEMP")]
public partial class TfsTbRptEmpwiseTrackingTemp
{
    [Key]
    [Column("sl_no")]
    public long SlNo { get; set; }

    [Column("emp_ref_no")]
    public string? EmpRefNo { get; set; }

    [Column("empcode")]
    [StringLength(50)]
    public string? Empcode { get; set; }

    [Column("employeename")]
    public string? Employeename { get; set; }

    [Column("designation")]
    [StringLength(50)]
    public string? Designation { get; set; }

    [Column("assigned_orders")]
    public long? AssignedOrders { get; set; }

    [Column("total_research_orders")]
    public long? TotalResearchOrders { get; set; }

    [Column("total_dataentry_orders")]
    [StringLength(10)]
    public string? TotalDataentryOrders { get; set; }

    [Column("total_orders")]
    public long? TotalOrders { get; set; }

    [Column("company_id")]
    public long? CompanyId { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }

    [Column("designation_id")]
    public long? DesignationId { get; set; }
}
