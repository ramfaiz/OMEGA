using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_RPT_EMP_PERFOMANCE_TEMP_1")]
public partial class TfsTbRptEmpPerfomanceTemp1
{
    [Column("emp_ref_no")]
    public string? EmpRefNo { get; set; }

    [Column("empcode")]
    [StringLength(50)]
    public string? Empcode { get; set; }

    [Column("employeename")]
    public string? Employeename { get; set; }

    [Column("assigned_orders")]
    public int? AssignedOrders { get; set; }

    [Column("sl_no")]
    public long? SlNo { get; set; }

    [Column("order_date")]
    public string? OrderDate { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("client_name")]
    public string? ClientName { get; set; }

    [Column("order_type")]
    [StringLength(20)]
    public string? OrderType { get; set; }

    [Column("due_date")]
    public string? DueDate { get; set; }

    [Column("order_starttime")]
    public string? OrderStarttime { get; set; }

    [Column("order_endtime")]
    public string? OrderEndtime { get; set; }

    [Column("time_taken")]
    public string? TimeTaken { get; set; }

    [Column("company_id")]
    public long? CompanyId { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }

    [Column("designation_id")]
    public long? DesignationId { get; set; }

    [Column("status_name")]
    [StringLength(100)]
    public string? StatusName { get; set; }

    [Column("from_date")]
    public string? FromDate { get; set; }

    [Column("to_date")]
    public string? ToDate { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }
}
