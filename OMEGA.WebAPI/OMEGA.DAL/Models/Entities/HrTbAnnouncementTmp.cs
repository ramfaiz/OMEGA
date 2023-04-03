using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("HR_TB_ANNOUNCEMENT_TMP")]
public partial class HrTbAnnouncementTmp
{
    [Column("entry_ref_no")]
    public long EntryRefNo { get; set; }

    [Column("entry_date", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("entry_title")]
    [StringLength(600)]
    public string? EntryTitle { get; set; }

    [Column("entry_detail")]
    public string? EntryDetail { get; set; }

    [Column("entry_posted_by")]
    [StringLength(240)]
    public string? EntryPostedBy { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("status")]
    public byte? Status { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("limit_detail_char_count")]
    public short? LimitDetailCharCount { get; set; }

    [Column("priority")]
    public byte? Priority { get; set; }

    [Column("is_regular_circular")]
    public byte? IsRegularCircular { get; set; }

    [Column("submitted_datetime", TypeName = "datetime")]
    public DateTime? SubmittedDatetime { get; set; }

    [Column("submitted_by")]
    public long? SubmittedBy { get; set; }

    [Column("modified_datetime", TypeName = "datetime")]
    public DateTime? ModifiedDatetime { get; set; }

    [Column("modified_by")]
    public long? ModifiedBy { get; set; }

    [Column("approved_datetime", TypeName = "datetime")]
    public DateTime? ApprovedDatetime { get; set; }

    [Column("approved_by")]
    public long? ApprovedBy { get; set; }

    [Column("approved_by_remarks")]
    [StringLength(1500)]
    public string? ApprovedByRemarks { get; set; }

    [Column("rejected_datetime", TypeName = "datetime")]
    public DateTime? RejectedDatetime { get; set; }

    [Column("rejected_by")]
    public long? RejectedBy { get; set; }

    [Column("rejected_by_remarks")]
    [StringLength(1500)]
    public string? RejectedByRemarks { get; set; }
}
