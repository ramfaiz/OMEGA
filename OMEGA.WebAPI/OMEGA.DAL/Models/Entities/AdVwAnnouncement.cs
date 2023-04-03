using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwAnnouncement
{
    [Column("entry_ref_no")]
    public long EntryRefNo { get; set; }

    [Column("entry_date", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("entry_title")]
    [StringLength(600)]
    public string? EntryTitle { get; set; }

    [Column("entry_posted_by")]
    public long? EntryPostedBy { get; set; }

    [Column("entry_detail")]
    public string? EntryDetail { get; set; }

    [Column("see_more")]
    public int SeeMore { get; set; }

    [Column("is_company_specific")]
    public byte? IsCompanySpecific { get; set; }

    [Column("is_org_specific")]
    public byte? IsOrgSpecific { get; set; }

    [Column("is_company_dept_specific")]
    public byte? IsCompanyDeptSpecific { get; set; }

    [Column("is_emp_specific")]
    public byte? IsEmpSpecific { get; set; }

    [Column("submitted_datetime", TypeName = "datetime")]
    public DateTime? SubmittedDatetime { get; set; }

    [Column("priority")]
    public byte? Priority { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("status")]
    public byte? Status { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("modified_datetime", TypeName = "datetime")]
    public DateTime? ModifiedDatetime { get; set; }

    [Column("modified_by")]
    public long? ModifiedBy { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string? Specificness { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PostedName { get; set; }

    [Column("readby")]
    public string? Readby { get; set; }
}
