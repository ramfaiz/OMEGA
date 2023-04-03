using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwOrderlist
{
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("order_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("order_rev_no")]
    public long? OrderRevNo { get; set; }

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

    [Column("is_review_checked")]
    public byte? IsReviewChecked { get; set; }

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

    [Column("bts_order_id")]
    public long? BtsOrderId { get; set; }

    [Column("is_from_bts")]
    public byte? IsFromBts { get; set; }

    [Column("parent_ord_id")]
    public int? ParentOrdId { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("subclient")]
    [StringLength(100)]
    public string? Subclient { get; set; }

    [Column("Is_Client_Submission")]
    public byte? IsClientSubmission { get; set; }

    [Column("order_accepted_by")]
    public long? OrderAcceptedBy { get; set; }

    [Column("is_comment")]
    public byte? IsComment { get; set; }

    [Column("order_posted_by")]
    [StringLength(500)]
    public string? OrderPostedBy { get; set; }

    [Column("order_due_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? OrderDueDate { get; set; }

    [Column("state_name")]
    [StringLength(500)]
    public string? StateName { get; set; }

    [Column("state_abb")]
    [StringLength(500)]
    public string? StateAbb { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("created_by")]
    [StringLength(101)]
    public string? CreatedBy { get; set; }

    [Column("order_dates")]
    [StringLength(30)]
    [Unicode(false)]
    public string? OrderDates { get; set; }

    [Column("zip_code")]
    [StringLength(50)]
    public string? ZipCode { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("auto_bpo_status_desc")]
    [StringLength(50)]
    public string? AutoBpoStatusDesc { get; set; }

    [Column("auto_bpo_status_id")]
    public int? AutoBpoStatusId { get; set; }

    public bool? IsProcessing { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }

    [Column("mls_id")]
    public int? MlsId { get; set; }

    [Column("ist_due_time", TypeName = "datetime")]
    public DateTime? IstDueTime { get; set; }

    [Unicode(false)]
    public string? ReassignedNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReassignedDate { get; set; }

    public long? CancelledBy { get; set; }

    [Unicode(false)]
    public string? CancelledNotes { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Check { get; set; }

    [Column("notes_for_client")]
    public string? NotesForClient { get; set; }

    [Column("order_value", TypeName = "numeric(18, 2)")]
    public decimal? OrderValue { get; set; }

    [Column("is_paid")]
    public byte? IsPaid { get; set; }

    [Column("latitude")]
    public string? Latitude { get; set; }

    [Column("longitude")]
    public string? Longitude { get; set; }

    [Column("mls_site_ref_no")]
    public string? MlsSiteRefNo { get; set; }

    [Column("instructions")]
    public string? Instructions { get; set; }

    [Column("file_path")]
    public string? FilePath { get; set; }

    [Column("spl_instructions")]
    public string? SplInstructions { get; set; }
}
