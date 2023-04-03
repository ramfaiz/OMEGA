using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwAnnouncementList
{
    [Column("entry_ref_no")]
    public long EntryRefNo { get; set; }

    [Column("entry_date")]
    [StringLength(30)]
    public string? EntryDate { get; set; }

    [Column("entry_title")]
    [StringLength(600)]
    public string? EntryTitle { get; set; }

    [Column("entry_detail")]
    public string? EntryDetail { get; set; }

    [Column("short_entry_detail")]
    public string? ShortEntryDetail { get; set; }

    [Column("see_more")]
    public int SeeMore { get; set; }

    [Column("expiry_date")]
    [StringLength(30)]
    public string? ExpiryDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("submitted_datetime")]
    [StringLength(30)]
    public string? SubmittedDatetime { get; set; }

    [Column("is_org_specific")]
    public byte? IsOrgSpecific { get; set; }

    [Column("is_company_specific")]
    public byte? IsCompanySpecific { get; set; }

    [Column("is_company_dept_specific")]
    public byte? IsCompanyDeptSpecific { get; set; }

    [Column("is_emp_specific")]
    public byte? IsEmpSpecific { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("comp_ref_no")]
    public long? CompRefNo { get; set; }

    [Column("dept_ref_no")]
    public long? DeptRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("status")]
    public byte? Status { get; set; }

    [Column("priority")]
    public byte? Priority { get; set; }

    [Column("entry_posted_by")]
    public long? EntryPostedBy { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PostedName { get; set; }

    [Column("entry_dref_no")]
    public long EntryDrefNo { get; set; }

    [Column("readby")]
    public string? Readby { get; set; }
}
