using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("LEAVE_ENTRY")]
public partial class LeaveEntry
{
    [Key]
    [Column("leave_ref_no")]
    public long LeaveRefNo { get; set; }

    [Column("leave_org_ref_no")]
    public long? LeaveOrgRefNo { get; set; }

    [Column("leave_comp_ref_no")]
    public long? LeaveCompRefNo { get; set; }

    [Column("leave_dept_ref_no")]
    public long? LeaveDeptRefNo { get; set; }

    [Column("leave_emp_ref_no")]
    public long? LeaveEmpRefNo { get; set; }

    [Column("leave_empt_detail_ref_no")]
    public long? LeaveEmptDetailRefNo { get; set; }

    [Column("leave_empt_leave_ref_no")]
    public long? LeaveEmptLeaveRefNo { get; set; }

    [Column("leave_status")]
    public int? LeaveStatus { get; set; }

    [Column("entry_date", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("leave_start_date", TypeName = "datetime")]
    public DateTime? LeaveStartDate { get; set; }

    [Column("leave_end_date", TypeName = "datetime")]
    public DateTime? LeaveEndDate { get; set; }

    [Column("leave_days", TypeName = "numeric(18, 1)")]
    public decimal? LeaveDays { get; set; }

    [Column("leave_type_id")]
    public int? LeaveTypeId { get; set; }

    [Column("total_paid_leaves", TypeName = "numeric(18, 1)")]
    public decimal? TotalPaidLeaves { get; set; }

    [Column("total_unpaid_leaves", TypeName = "numeric(18, 1)")]
    public decimal? TotalUnpaidLeaves { get; set; }

    [Column("leave_remarks")]
    [StringLength(240)]
    public string? LeaveRemarks { get; set; }

    [Column("contact_address")]
    [StringLength(240)]
    public string? ContactAddress { get; set; }

    [Column("city")]
    [StringLength(60)]
    public string? City { get; set; }

    [Column("tel_no")]
    [StringLength(60)]
    public string? TelNo { get; set; }

    [Column("ad_fin_finyrid")]
    public short? AdFinFinyrid { get; set; }

    [Column("delayed_days", TypeName = "numeric(18, 1)")]
    public decimal? DelayedDays { get; set; }

    [Column("resumption_date", TypeName = "datetime")]
    public DateTime? ResumptionDate { get; set; }

    [Column("is_rejoined")]
    public byte? IsRejoined { get; set; }

    [Column("rejoin_date", TypeName = "datetime")]
    public DateTime? RejoinDate { get; set; }

    [Column("rejoin_remarks")]
    [StringLength(600)]
    public string? RejoinRemarks { get; set; }

    [Column("leave_lastsubmitted_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastsubmittedDatetime { get; set; }

    [Column("leave_approvedby_ref_no")]
    public long? LeaveApprovedbyRefNo { get; set; }

    [Column("leave_approvedby_remarks")]
    [StringLength(240)]
    public string? LeaveApprovedbyRemarks { get; set; }

    [Column("leave_lastapproved_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastapprovedDatetime { get; set; }

    [Column("leave_rejectedby_ref_no")]
    public long? LeaveRejectedbyRefNo { get; set; }

    [Column("leave_rejectedby_remarks")]
    [StringLength(240)]
    public string? LeaveRejectedbyRemarks { get; set; }

    [Column("leave_lastrejected_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastrejectedDatetime { get; set; }

    [Column("leave_generatedby_ref_no")]
    public long? LeaveGeneratedbyRefNo { get; set; }

    [Column("leave_generatedby_remarks")]
    [StringLength(240)]
    public string? LeaveGeneratedbyRemarks { get; set; }

    [Column("leave_lastgenerated_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastgeneratedDatetime { get; set; }

    [Column("leave_processedby_ref_no")]
    public long? LeaveProcessedbyRefNo { get; set; }

    [Column("leave_processedby_remarks")]
    [StringLength(240)]
    public string? LeaveProcessedbyRemarks { get; set; }

    [Column("leave_lastprocessed_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastprocessedDatetime { get; set; }

    [Column("leave_administratedby_ref_no")]
    public long? LeaveAdministratedbyRefNo { get; set; }

    [Column("leave_administratedby_remarks")]
    [StringLength(240)]
    public string? LeaveAdministratedbyRemarks { get; set; }

    [Column("leave_lastadministrated_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastadministratedDatetime { get; set; }

    [Column("leave_lockedby_ref_no")]
    public long? LeaveLockedbyRefNo { get; set; }

    [Column("leave_lockedby_remarks")]
    [StringLength(240)]
    public string? LeaveLockedbyRemarks { get; set; }

    [Column("leave_lastlocked_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastlockedDatetime { get; set; }

    [Column("leave_email_ref_no")]
    public long? LeaveEmailRefNo { get; set; }

    [Column("leave_lastmodified_datetime", TypeName = "datetime")]
    public DateTime? LeaveLastmodifiedDatetime { get; set; }

    [Column("leave_lastmodified_by")]
    public int? LeaveLastmodifiedBy { get; set; }

    [Column("delete_status")]
    public int? DeleteStatus { get; set; }

    [InverseProperty("LeaveRefNoNavigation")]
    public virtual ICollection<LeaveEntryDetail> LeaveEntryDetails { get; } = new List<LeaveEntryDetail>();
}
