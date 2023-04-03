using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_RPT_INCENTIVE_TEMP")]
public partial class TfsTbRptIncentiveTemp
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
    public string? Designation { get; set; }

    [Column("min_order")]
    public int? MinOrder { get; set; }

    [Column("total_order")]
    public int? TotalOrder { get; set; }

    [Column("incentive_order")]
    public int? IncentiveOrder { get; set; }

    [Column("total_incentive", TypeName = "decimal(10, 2)")]
    public decimal? TotalIncentive { get; set; }

    [Column("designation_id")]
    public long? DesignationId { get; set; }

    [Column("company_id")]
    public long? CompanyId { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
