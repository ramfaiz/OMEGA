using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwInvoiceGenOrderListOld
{
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("order_rev_no")]
    public long? OrderRevNo { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("subject_address")]
    [StringLength(500)]
    public string? SubjectAddress { get; set; }

    [Column("state_id")]
    public short? StateId { get; set; }

    [Column("county_id")]
    public short? CountyId { get; set; }

    [Column("order_type")]
    public short? OrderType { get; set; }

    [Column("order_urgency")]
    public byte? OrderUrgency { get; set; }

    [Column("order_priority")]
    public short? OrderPriority { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }

    [Column("photo_req_status")]
    public short? PhotoReqStatus { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("comp_ref_no")]
    public long? CompRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("view_id")]
    public long? ViewId { get; set; }

    [Column("priority_param_id")]
    public byte? PriorityParamId { get; set; }

    [Column("emp_priority")]
    public short? EmpPriority { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("update_date", TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }

    [Column("update_by")]
    public long? UpdateBy { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [Column("parent_ord_id")]
    public int? ParentOrdId { get; set; }

    [Column("ord_seq_no")]
    public int? OrdSeqNo { get; set; }

    [Column("is_review_checked")]
    public byte? IsReviewChecked { get; set; }

    [Column("mls_site_ref_no")]
    public long? MlsSiteRefNo { get; set; }

    [Column("ord_revision_flag")]
    public byte? OrdRevisionFlag { get; set; }

    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column("bts_order_id")]
    public long? BtsOrderId { get; set; }

    [Column("is_from_bts")]
    public byte? IsFromBts { get; set; }

    [Column("is_transfer")]
    public byte? IsTransfer { get; set; }

    [Column("order_type_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrderTypeName { get; set; }

    [Column("is_qa_submit")]
    public byte? IsQaSubmit { get; set; }

    [Column("Portal_Name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("is_invoiced")]
    public byte? IsInvoiced { get; set; }
}
