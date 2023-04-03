using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwBpoOrderList1
{
    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("cpd_ref_no")]
    public long? CpdRefNo { get; set; }

    [Column("cpd_report_to")]
    public long? CpdReportTo { get; set; }

    [Column("order_no")]
    public long OrderNo { get; set; }

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

    [Column("order_delete_status")]
    public byte? OrderDeleteStatus { get; set; }

    [Column("ordertype_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrdertypeName { get; set; }

    [Column("status_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StatusName { get; set; }

    [Column("pht_name")]
    [StringLength(100)]
    public string? PhtName { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("is_photo_upload")]
    public byte? IsPhotoUpload { get; set; }

    [Column("is_mail_remaind")]
    public byte? IsMailRemaind { get; set; }

    [Column("is_bulk_order")]
    public byte? IsBulkOrder { get; set; }

    [Column("subclient_id")]
    public long? SubclientId { get; set; }

    [Column("order_portal_no")]
    [StringLength(500)]
    public string? OrderPortalNo { get; set; }
}
