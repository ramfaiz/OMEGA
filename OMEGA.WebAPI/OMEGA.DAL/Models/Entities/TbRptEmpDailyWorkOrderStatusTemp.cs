using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TB_RPT_EMP_DAILY_WORK_ORDER_STATUS_TEMP")]
public partial class TbRptEmpDailyWorkOrderStatusTemp
{
    [Column("emp_ref_no")]
    public string? EmpRefNo { get; set; }

    [Column("employee_name")]
    public string? EmployeeName { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("client_name")]
    public string? ClientName { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("status_reason_desc")]
    public string? StatusReasonDesc { get; set; }

    [Column("order_type_display")]
    public string? OrderTypeDisplay { get; set; }

    [Column("start_date_time", TypeName = "date")]
    public DateTime? StartDateTime { get; set; }

    [Column("end_date_time", TypeName = "date")]
    public DateTime? EndDateTime { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }

    [Column("empt_comp_id")]
    public long? EmptCompId { get; set; }

    [Column("empt_desig_id")]
    public long? EmptDesigId { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
