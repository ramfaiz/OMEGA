using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwCustomerOrderStatus1
{
    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("status_id")]
    public long? StatusId { get; set; }

    [Column("status_reason_id")]
    public long? StatusReasonId { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("emp_first_name")]
    [StringLength(101)]
    public string? EmpFirstName { get; set; }

    [Column("start_datetime", TypeName = "datetime")]
    public DateTime? StartDatetime { get; set; }

    [Column("end_datetime")]
    [StringLength(19)]
    [Unicode(false)]
    public string? EndDatetime { get; set; }

    [Column("parent_ord_id")]
    public int? ParentOrdId { get; set; }

    [Column("view_id")]
    public long ViewId { get; set; }

    [Column("is_redo_revision")]
    public byte? IsRedoRevision { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("for_emp_ref_no")]
    public long? ForEmpRefNo { get; set; }

    [Column("for_emp_name")]
    [StringLength(102)]
    public string? ForEmpName { get; set; }
}
