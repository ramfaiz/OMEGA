using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwAcceptOrderlist
{
    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Urgency { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Priority { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("priority_param_id")]
    public byte? PriorityParamId { get; set; }

    [Column("emp_priority")]
    public short? EmpPriority { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("order_rev_no")]
    public long? OrderRevNo { get; set; }

    [Column("order_urgency")]
    public byte? OrderUrgency { get; set; }

    [Column("order_priority")]
    public byte? OrderPriority { get; set; }

    [Column("order_type")]
    public byte? OrderType { get; set; }

    [Column("status_id")]
    public short? StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }

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

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("access_level")]
    public short? AccessLevel { get; set; }

    [Column("priority_param_desc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? PriorityParamDesc { get; set; }

    [Column("is_review_flag")]
    public byte? IsReviewFlag { get; set; }

    [Column("clarification_status")]
    public short? ClarificationStatus { get; set; }

    [Column("c_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CStatusDesc { get; set; }

    [Column("photo_req_status")]
    public short? PhotoReqStatus { get; set; }

    [Column("ord_revision_flag")]
    public byte? OrdRevisionFlag { get; set; }

    [Column("is_ngl_client")]
    public byte? IsNglClient { get; set; }

    [Column("is_review_checked")]
    public byte? IsReviewChecked { get; set; }

    [Column("is_transfer")]
    public byte? IsTransfer { get; set; }

    [Column("photo_req_status_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoReqStatusDesc { get; set; }

    [Column("is_qa_submit")]
    public byte? IsQaSubmit { get; set; }

    [Column("site_ref_no")]
    public long? SiteRefNo { get; set; }

    [Column("portal_name")]
    [StringLength(500)]
    public string? PortalName { get; set; }

    [Column("due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DueDate { get; set; }

    [Column("update_date", TypeName = "datetime")]
    public DateTime? UpdateDate { get; set; }

    [Column("DM_DISTRICT_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DmDistrictName { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("bts_order_id")]
    public long? BtsOrderId { get; set; }

    [Column("is_from_bts")]
    public byte? IsFromBts { get; set; }

    [Column("parent_ord_id")]
    public int? ParentOrdId { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("view_id")]
    public long? ViewId { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("order_accepted_by")]
    public long? OrderAcceptedBy { get; set; }
}
