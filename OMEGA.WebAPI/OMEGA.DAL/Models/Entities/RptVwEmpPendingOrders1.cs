using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmpPendingOrders1
{
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("state_id")]
    public short? StateId { get; set; }

    [Column("county_id")]
    public short? CountyId { get; set; }

    [Column("subject_address")]
    [StringLength(500)]
    public string? SubjectAddress { get; set; }

    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }

    [Column("clarification")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Clarification { get; set; }

    [Column("order_type_id")]
    public short? OrderTypeId { get; set; }

    [Column("order_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrderType { get; set; }

    [Column("start_datetime", TypeName = "datetime")]
    public DateTime? StartDatetime { get; set; }

    [Column("end_datetime", TypeName = "datetime")]
    public DateTime? EndDatetime { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("language_code")]
    public short? LanguageCode { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("empt_desig_id")]
    public short? EmptDesigId { get; set; }

    [Column("order_date_display")]
    [StringLength(30)]
    [Unicode(false)]
    public string? OrderDateDisplay { get; set; }

    [Column("due_date_display")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DueDateDisplay { get; set; }

    [Column("employee_name")]
    [StringLength(101)]
    public string EmployeeName { get; set; } = null!;

    [Column("status_reason_id")]
    public long? StatusReasonId { get; set; }

    [Column("status_id")]
    public long? StatusId { get; set; }
}
