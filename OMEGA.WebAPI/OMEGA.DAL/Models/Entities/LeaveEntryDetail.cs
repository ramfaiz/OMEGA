using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("LEAVE_ENTRY_DETAILS")]
public partial class LeaveEntryDetail
{
    [Key]
    [Column("leave_dref_no")]
    public long LeaveDrefNo { get; set; }

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

    [Column("leave_ref_no")]
    public long? LeaveRefNo { get; set; }

    [Column("leave_dtype_id")]
    public int? LeaveDtypeId { get; set; }

    [Column("leave_ddate", TypeName = "datetime")]
    public DateTime? LeaveDdate { get; set; }

    [Column("leave_dday", TypeName = "numeric(18, 1)")]
    public decimal? LeaveDday { get; set; }

    [Column("leave_dtime")]
    public int? LeaveDtime { get; set; }

    [Column("is_unpaid_leave")]
    public byte? IsUnpaidLeave { get; set; }

    [Column("leave_dremarks")]
    [StringLength(240)]
    public string? LeaveDremarks { get; set; }

    [Column("leave_dapprovedby_ref_no")]
    public long? LeaveDapprovedbyRefNo { get; set; }

    [Column("leave_dapprovedby_remarks")]
    [StringLength(240)]
    public string? LeaveDapprovedbyRemarks { get; set; }

    [Column("leave_dlastapproved_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastapprovedDatetime { get; set; }

    [Column("leave_drejectedby_ref_no")]
    public long? LeaveDrejectedbyRefNo { get; set; }

    [Column("leave_drejectedby_remarks")]
    [StringLength(240)]
    public string? LeaveDrejectedbyRemarks { get; set; }

    [Column("leave_dlastrejected_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastrejectedDatetime { get; set; }

    [Column("leave_dgeneratedby_ref_no")]
    public long? LeaveDgeneratedbyRefNo { get; set; }

    [Column("leave_dgeneratedby_remarks")]
    [StringLength(240)]
    public string? LeaveDgeneratedbyRemarks { get; set; }

    [Column("leave_dlastgenerated_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastgeneratedDatetime { get; set; }

    [Column("leave_dprocessedby_refno")]
    public long? LeaveDprocessedbyRefno { get; set; }

    [Column("leave_dprocessedby_remarks")]
    [StringLength(240)]
    public string? LeaveDprocessedbyRemarks { get; set; }

    [Column("leave_dlastprocessed_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastprocessedDatetime { get; set; }

    [Column("leave_dadministratedby_refno")]
    public long? LeaveDadministratedbyRefno { get; set; }

    [Column("leave_dadministratedby_remarks")]
    [StringLength(240)]
    public string? LeaveDadministratedbyRemarks { get; set; }

    [Column("leave_dlastadministrated_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastadministratedDatetime { get; set; }

    [Column("leave_dlockedby_refno")]
    public long? LeaveDlockedbyRefno { get; set; }

    [Column("leave_dlockedby_remarks")]
    [StringLength(240)]
    public string? LeaveDlockedbyRemarks { get; set; }

    [Column("leave_dlastlocked_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastlockedDatetime { get; set; }

    [Column("leave_dlastmodified_datetime", TypeName = "datetime")]
    public DateTime? LeaveDlastmodifiedDatetime { get; set; }

    [Column("leave_dlastmodifiedby")]
    public int? LeaveDlastmodifiedby { get; set; }

    [ForeignKey("LeaveRefNo")]
    [InverseProperty("LeaveEntryDetails")]
    public virtual LeaveEntry? LeaveRefNoNavigation { get; set; }
}
