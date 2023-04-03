using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmploymentDetail
{
    [Column("confirmation_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ConfirmationDate { get; set; }

    [Column("organisation")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Organisation { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("company")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Company { get; set; }

    [Column("department")]
    [StringLength(240)]
    public string? Department { get; set; }

    [Column("joining_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? JoiningDate { get; set; }

    [Column("probation_period")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProbationPeriod { get; set; }

    [Column("verified_remarks")]
    [StringLength(240)]
    public string? VerifiedRemarks { get; set; }

    [Column("termination_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? TerminationDate { get; set; }

    [Column("temination_reason")]
    [StringLength(240)]
    public string? TeminationReason { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("cpf_entitiled")]
    public byte? CpfEntitiled { get; set; }

    [Column("income_tax_id")]
    [StringLength(100)]
    public string? IncomeTaxId { get; set; }

    [Column("race_id")]
    public int? RaceId { get; set; }

    [Column("bank_branch_code")]
    [StringLength(100)]
    public string? BankBranchCode { get; set; }

    [Column("bank_code")]
    [StringLength(100)]
    public string? BankCode { get; set; }

    [Column("bank_account_no")]
    [StringLength(100)]
    public string? BankAccountNo { get; set; }

    [Column("bank_account_name")]
    [StringLength(240)]
    public string? BankAccountName { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("bank_name")]
    [StringLength(240)]
    public string? BankName { get; set; }

    [Column("empt_status")]
    [StringLength(6)]
    [Unicode(false)]
    public string? EmptStatus { get; set; }

    [Column("employment_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmploymentType { get; set; }

    [Column("work_day_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WorkDayType { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(152)]
    public string? EmployeeName { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("notice_period")]
    [StringLength(60)]
    [Unicode(false)]
    public string? NoticePeriod { get; set; }

    [Column("night_shift")]
    [StringLength(3)]
    [Unicode(false)]
    public string NightShift { get; set; } = null!;
}
