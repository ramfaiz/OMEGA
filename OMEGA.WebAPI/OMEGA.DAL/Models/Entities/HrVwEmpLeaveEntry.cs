using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmpLeaveEntry
{
    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("LM_LOCATION_ID")]
    public int LmLocationId { get; set; }

    [Column("LM_LOCATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? LmLocationName { get; set; }

    [Column("SM_STATION_ID")]
    public int SmStationId { get; set; }

    [Column("SM_STATION_NAME")]
    [StringLength(240)]
    [Unicode(false)]
    public string? SmStationName { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("display_value")]
    [StringLength(240)]
    public string? DisplayValue { get; set; }

    [Column("dept_id")]
    public short DeptId { get; set; }

    [Column("Dep_Name")]
    [StringLength(240)]
    public string? DepName { get; set; }

    [Column("leave_ref_no")]
    public long LeaveRefNo { get; set; }

    [Column("leave_emp_ref_no")]
    public long? LeaveEmpRefNo { get; set; }

    [Column("leave_status")]
    public int? LeaveStatus { get; set; }

    [Column("leave_start_date", TypeName = "datetime")]
    public DateTime? LeaveStartDate { get; set; }

    [Column("leave_end_date", TypeName = "datetime")]
    public DateTime? LeaveEndDate { get; set; }

    [Column("leave_days", TypeName = "numeric(18, 1)")]
    public decimal? LeaveDays { get; set; }

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

    [Column("delete_status")]
    public int? DeleteStatus { get; set; }

    [Column("leave_type_id")]
    public int? LeaveTypeId { get; set; }

    [Column("Leave_Type")]
    [StringLength(200)]
    public string? LeaveType { get; set; }

    [Column("leave_empt_leave_ref_no")]
    public long? LeaveEmptLeaveRefNo { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("entry_date", TypeName = "datetime")]
    public DateTime? EntryDate { get; set; }

    [Column("status1")]
    [StringLength(9)]
    [Unicode(false)]
    public string? Status1 { get; set; }

    [Column("cancelled_status")]
    [StringLength(3)]
    [Unicode(false)]
    public string? CancelledStatus { get; set; }

    [Column("leave_dtime")]
    public int? LeaveDtime { get; set; }

    [Column("approved_by")]
    public long? ApprovedBy { get; set; }

    [Column("leave_rejectedby_ref_no")]
    public long? LeaveRejectedbyRefNo { get; set; }

    [Column("leave_approvedby_remarks")]
    [StringLength(240)]
    public string? LeaveApprovedbyRemarks { get; set; }

    [Column("leave_rejectedby_remarks")]
    [StringLength(240)]
    public string? LeaveRejectedbyRemarks { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("residence_country")]
    public long? ResidenceCountry { get; set; }

    [Column("empt_set_ref_no")]
    public long? EmptSetRefNo { get; set; }

    [Column("total_paid_leaves", TypeName = "numeric(18, 1)")]
    public decimal? TotalPaidLeaves { get; set; }

    [Column("total_unpaid_leaves", TypeName = "numeric(18, 1)")]
    public decimal? TotalUnpaidLeaves { get; set; }

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

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("file_name")]
    [StringLength(100)]
    public string? FileName { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }
}
