using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwGridList
{
    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("status_reason_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusReasonDesc { get; set; }

    [Column("status_desc")]
    [StringLength(240)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("emp_first_name")]
    [StringLength(101)]
    public string? EmpFirstName { get; set; }

    [Column("ordertypename")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Ordertypename { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("c_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CStatusDesc { get; set; }

    [Column("photo_req_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoReqStatusDesc { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DueDate { get; set; }

    [Column("subclient")]
    [StringLength(100)]
    public string? Subclient { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("ord_revision_flag")]
    public byte? OrdRevisionFlag { get; set; }

    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("is_review_checked")]
    public byte? IsReviewChecked { get; set; }

    [Column("photo_req_status")]
    public short? PhotoReqStatus { get; set; }

    [Column("state_name")]
    [StringLength(500)]
    public string? StateName { get; set; }

    [Column("state_abb")]
    [StringLength(500)]
    public string? StateAbb { get; set; }

    [Column("ref_no")]
    public long? RefNo { get; set; }
}
