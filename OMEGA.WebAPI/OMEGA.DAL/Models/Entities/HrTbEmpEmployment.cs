using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMP_EMPLOYMENT")]
public partial class HrTbEmpEmployment
{
    [Key]
    [Column("empt_ref_no")]
    public long EmptRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("cpf_entitiled")]
    public byte? CpfEntitiled { get; set; }

    [Column("cpf_type")]
    public int? CpfType { get; set; }

    [Column("is_compute_cpf_first_half")]
    public byte? IsComputeCpfFirstHalf { get; set; }

    [Column("employee_cpf_ac_no")]
    [StringLength(50)]
    public string? EmployeeCpfAcNo { get; set; }

    [Column("income_tax_id")]
    [StringLength(100)]
    public string? IncomeTaxId { get; set; }

    [Column("is_compute_fund_first_half")]
    public byte? IsComputeFundFirstHalf { get; set; }

    [Column("is_fund_opt_out")]
    public byte? IsFundOptOut { get; set; }

    [Column("is_sdl_opt_out")]
    public byte? IsSdlOptOut { get; set; }

    [Column("race_id")]
    public int? RaceId { get; set; }

    [Column("empmt_commencement_dt", TypeName = "date")]
    public DateTime? EmpmtCommencementDt { get; set; }

    [Column("empmt_commence_dt_prev_agency")]
    [StringLength(100)]
    public string? EmpmtCommenceDtPrevAgency { get; set; }

    [Column("transition_indication")]
    public byte? TransitionIndication { get; set; }

    [Column("tendered_date", TypeName = "datetime")]
    public DateTime? TenderedDate { get; set; }

    [Column("reason_of_leaving")]
    [StringLength(500)]
    public string? ReasonOfLeaving { get; set; }

    [Column("resignation_type")]
    public int? ResignationType { get; set; }

    [Column("resignation_date", TypeName = "date")]
    public DateTime? ResignationDate { get; set; }

    [Column("is_probation_enabled")]
    public byte? IsProbationEnabled { get; set; }

    [Column("probation_start_date", TypeName = "date")]
    public DateTime? ProbationStartDate { get; set; }

    [Column("probation_end_date", TypeName = "date")]
    public DateTime? ProbationEndDate { get; set; }

    [Column("salary_payment_mode")]
    public int? SalaryPaymentMode { get; set; }

    [Column("recruited_by_company")]
    public int? RecruitedByCompany { get; set; }

    [Column("recruiter_user_ref_no")]
    public long? RecruiterUserRefNo { get; set; }

    [Column("recommender_user_ref_no")]
    public int? RecommenderUserRefNo { get; set; }

    [Column("medical_card_status")]
    public byte? MedicalCardStatus { get; set; }

    [Column("medical_card_expiry_date", TypeName = "date")]
    public DateTime? MedicalCardExpiryDate { get; set; }

    [Column("empmt_identity_card_status")]
    public byte? EmpmtIdentityCardStatus { get; set; }

    [Column("empmt_remarks")]
    [StringLength(500)]
    public string? EmpmtRemarks { get; set; }

    [Column("empmt_higest_qualfication")]
    public int? EmpmtHigestQualfication { get; set; }

    [Column("bank_identifier_code")]
    [StringLength(60)]
    public string? BankIdentifierCode { get; set; }

    [Column("bank_code")]
    [StringLength(100)]
    public string? BankCode { get; set; }

    [Column("bank_branch_code")]
    [StringLength(100)]
    public string? BankBranchCode { get; set; }

    [Column("bank_account_no")]
    [StringLength(100)]
    public string? BankAccountNo { get; set; }

    [Column("bank_account_name")]
    [StringLength(240)]
    public string? BankAccountName { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("delete_status")]
    public byte DeleteStatus { get; set; }

    [Column("category_id")]
    public short? CategoryId { get; set; }

    [Column("latest_emp_ref_no")]
    public long? LatestEmpRefNo { get; set; }

    [Column("emp_status")]
    public short? EmpStatus { get; set; }

    [Column("cpf_empt_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CpfEmptStatus { get; set; }

    [Column("empmt_highest_qual_remarks")]
    [StringLength(255)]
    public string? EmpmtHighestQualRemarks { get; set; }

    [Column("calender_type")]
    public byte? CalenderType { get; set; }
}
