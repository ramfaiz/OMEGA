using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_BPO_ORDER")]
public partial class BtsTbBpoOrder
{
    [Column("order_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrderNo { get; set; }

    [Column("order_code")]
    [StringLength(500)]
    public string? OrderCode { get; set; }

    [Column("order_posted_by")]
    [StringLength(500)]
    public string? OrderPostedBy { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("order_due_date", TypeName = "datetime")]
    public DateTime? OrderDueDate { get; set; }

    [Column("photo_due_date", TypeName = "datetime")]
    public DateTime? PhotoDueDate { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("city_id")]
    public long? CityId { get; set; }

    [Column("zip_code")]
    [StringLength(50)]
    public string? ZipCode { get; set; }

    [Column("county_id")]
    public long? CountyId { get; set; }

    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("photographer_id")]
    public long? PhotographerId { get; set; }

    [Column("dataentry_id")]
    public long? DataentryId { get; set; }

    [Column("qa_id")]
    public long? QaId { get; set; }

    [Column("is_qa_required")]
    public long? IsQaRequired { get; set; }

    [Column("order_type")]
    public byte? OrderType { get; set; }

    [Column("order_urgency")]
    public byte? OrderUrgency { get; set; }

    [Column("order_priority")]
    public byte? OrderPriority { get; set; }

    [Column("order_status")]
    public byte? OrderStatus { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("notes_for_client")]
    public string? NotesForClient { get; set; }

    [Column("notes_for_pht")]
    public string? NotesForPht { get; set; }

    [Column("notes_for_dataentry")]
    public string? NotesForDataentry { get; set; }

    [Column("notes_for_qa")]
    public string? NotesForQa { get; set; }

    [Column("photo_fee", TypeName = "numeric(18, 2)")]
    public decimal? PhotoFee { get; set; }

    [Column("data_fee", TypeName = "numeric(18, 2)")]
    public decimal? DataFee { get; set; }

    [Column("qa_fee", TypeName = "numeric(18, 2)")]
    public decimal? QaFee { get; set; }

    [Column("order_value", TypeName = "numeric(18, 2)")]
    public decimal? OrderValue { get; set; }

    [Column("count_photo_upload")]
    public long? CountPhotoUpload { get; set; }

    [Column("count_file_upoad")]
    public long? CountFileUpoad { get; set; }

    [Column("is_entry_comp")]
    public byte? IsEntryComp { get; set; }

    [Column("is_paid")]
    public byte? IsPaid { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("latitude")]
    public string? Latitude { get; set; }

    [Column("longitude")]
    public string? Longitude { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("notes_from_pht")]
    public string? NotesFromPht { get; set; }

    [Column("notes_from_dataentry")]
    public string? NotesFromDataentry { get; set; }

    [Column("notes_from_qa")]
    public string? NotesFromQa { get; set; }

    [Column("reason_for_deletion")]
    public string? ReasonForDeletion { get; set; }

    [Column("subclient_id")]
    public long? SubclientId { get; set; }

    [Column("is_mail_remaind")]
    public byte? IsMailRemaind { get; set; }

    [Column("is_photo_upload")]
    public byte? IsPhotoUpload { get; set; }

    [Column("is_bulk_order")]
    public byte? IsBulkOrder { get; set; }

    [Column("order_portal_no")]
    [StringLength(500)]
    public string? OrderPortalNo { get; set; }

    [Key]
    [Column("order_id")]
    public long OrderId { get; set; }

    [Column("order_rev_no")]
    public long? OrderRevNo { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }

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
    public string? MlsSiteRefNo { get; set; }

    [Column("ord_revision_flag")]
    public byte? OrdRevisionFlag { get; set; }

    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column("is_from_bts")]
    public byte? IsFromBts { get; set; }

    [Column("is_transfer")]
    public byte? IsTransfer { get; set; }

    [Column("is_qa_submit")]
    public byte? IsQaSubmit { get; set; }

    [Column("is_invoiced")]
    public byte? IsInvoiced { get; set; }

    [Column("order_accepted_by")]
    public long? OrderAcceptedBy { get; set; }

    [Column("total_count")]
    public long? TotalCount { get; set; }

    [Column("is_comment")]
    public byte? IsComment { get; set; }

    [Column("bts_order_id")]
    public long? BtsOrderId { get; set; }

    [Column("est_time", TypeName = "datetime")]
    public DateTime? EstTime { get; set; }

    [Column("is_ordered")]
    public short? IsOrdered { get; set; }

    [Column("ist_due_time", TypeName = "datetime")]
    public DateTime? IstDueTime { get; set; }

    [Column("auto_bpo_status_id")]
    public int? AutoBpoStatusId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Check { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TimeFormat { get; set; }

    [Unicode(false)]
    public string? ReassignedNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReassignedDate { get; set; }

    public long? CancelledBy { get; set; }

    [Unicode(false)]
    public string? CancelledNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CancelledDate { get; set; }

    public bool? OrderNotified { get; set; }

    public bool? IsProcessing { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }

    [Column("mls_id")]
    public int? MlsId { get; set; }

    [Column("res_completed_time", TypeName = "datetime")]
    public DateTime? ResCompletedTime { get; set; }

    [Column("is_auto_bpo")]
    public short? IsAutoBpo { get; set; }

    [Column("rental_value")]
    public double? RentalValue { get; set; }

    [Column("instructions")]
    public string? Instructions { get; set; }

    [Column("spl_instructions")]
    public string? SplInstructions { get; set; }
}
