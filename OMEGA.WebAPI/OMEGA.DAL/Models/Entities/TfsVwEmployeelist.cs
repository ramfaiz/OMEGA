using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwEmployeelist
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_title")]
    [StringLength(50)]
    public string? EmpTitle { get; set; }

    [Column("emp_first_name")]
    [StringLength(50)]
    public string? EmpFirstName { get; set; }

    [Column("emp_middle_name")]
    [StringLength(50)]
    public string? EmpMiddleName { get; set; }

    [Column("emp_last_name")]
    [StringLength(50)]
    public string? EmpLastName { get; set; }

    [Column("employee_type")]
    public short? EmployeeType { get; set; }

    [Column("emp_org_id")]
    public long? EmpOrgId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("emp_dept_id")]
    public long? EmpDeptId { get; set; }

    [Column("blood_group")]
    public short? BloodGroup { get; set; }

    [Column("date_of_birth", TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [Column("religion")]
    public short? Religion { get; set; }

    [Column("gender")]
    public short? Gender { get; set; }

    [Column("nationality")]
    public short? Nationality { get; set; }

    [Column("residence_country")]
    public long? ResidenceCountry { get; set; }

    [Column("birth_place")]
    [StringLength(50)]
    public string? BirthPlace { get; set; }

    [Column("maritial_status")]
    public short? MaritialStatus { get; set; }

    [Column("father_name")]
    [StringLength(50)]
    public string? FatherName { get; set; }

    [Column("mother_name")]
    [StringLength(50)]
    public string? MotherName { get; set; }

    [Column("phone_number")]
    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("mobile_number")]
    [StringLength(50)]
    public string? MobileNumber { get; set; }

    [Column("alternate_mobile_number")]
    [StringLength(50)]
    public string? AlternateMobileNumber { get; set; }

    [Column("passport_number")]
    [StringLength(50)]
    public string? PassportNumber { get; set; }

    [Column("passport_validity", TypeName = "datetime")]
    public DateTime? PassportValidity { get; set; }

    [Column("punch_card_id")]
    public int? PunchCardId { get; set; }

    [Column("driving_license")]
    public short? DrivingLicense { get; set; }

    [Column("cpf_number")]
    [StringLength(100)]
    public string? CpfNumber { get; set; }

    [Column("tax_number")]
    [StringLength(100)]
    public string? TaxNumber { get; set; }

    [Column("identity_number")]
    [StringLength(100)]
    public string? IdentityNumber { get; set; }

    [Column("is_cdac")]
    public byte? IsCdac { get; set; }

    [Column("is_mbmf")]
    public byte? IsMbmf { get; set; }

    [Column("is_ecf")]
    public byte? IsEcf { get; set; }

    [Column("is_sinda")]
    public byte? IsSinda { get; set; }

    [Column("local_postal_code")]
    public int? LocalPostalCode { get; set; }

    [Column("local_country")]
    [StringLength(50)]
    public string? LocalCountry { get; set; }

    [Column("local_state")]
    [StringLength(50)]
    public string? LocalState { get; set; }

    [Column("local_street")]
    [StringLength(50)]
    public string? LocalStreet { get; set; }

    [Column("local_level")]
    [StringLength(50)]
    public string? LocalLevel { get; set; }

    [Column("local_unit")]
    [StringLength(50)]
    public string? LocalUnit { get; set; }

    [Column("foreign_country")]
    [StringLength(50)]
    public string? ForeignCountry { get; set; }

    [Column("foreign_postal_code")]
    public int? ForeignPostalCode { get; set; }

    [Column("foreign_state")]
    [StringLength(50)]
    public string? ForeignState { get; set; }

    [Column("foreign_street")]
    [StringLength(50)]
    public string? ForeignStreet { get; set; }

    [Column("foreign_level")]
    [StringLength(50)]
    public string? ForeignLevel { get; set; }

    [Column("foreign_unit")]
    [StringLength(50)]
    public string? ForeignUnit { get; set; }

    [Column("emrergency_contact_name")]
    [StringLength(50)]
    public string? EmrergencyContactName { get; set; }

    [Column("emrergency_contact_number")]
    [StringLength(50)]
    public string? EmrergencyContactNumber { get; set; }

    [Column("emrergency_contact_address")]
    [StringLength(100)]
    public string? EmrergencyContactAddress { get; set; }

    [Column("emergency_contact_relationship")]
    [StringLength(50)]
    public string? EmergencyContactRelationship { get; set; }

    [Column("emergency_contact_level")]
    [StringLength(50)]
    public string? EmergencyContactLevel { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("file_name")]
    [StringLength(100)]
    public string? FileName { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("bank_id")]
    public short? BankId { get; set; }

    [Column("bank_branch_code")]
    [StringLength(50)]
    public string? BankBranchCode { get; set; }

    [Column("bank_account_no")]
    [StringLength(50)]
    public string? BankAccountNo { get; set; }

    [Column("is_bank_confirmed")]
    public byte? IsBankConfirmed { get; set; }

    [Column("is_nric")]
    public byte? IsNric { get; set; }

    [Column("nric_fin_no")]
    [StringLength(100)]
    public string? NricFinNo { get; set; }

    [Column("pr_issue_date", TypeName = "datetime")]
    public DateTime? PrIssueDate { get; set; }

    [Column("pr_expiry_date", TypeName = "datetime")]
    public DateTime? PrExpiryDate { get; set; }

    [Column("emp_pass_type")]
    public int? EmpPassType { get; set; }

    [Column("emp_highest_qualfication")]
    [StringLength(50)]
    public string? EmpHighestQualfication { get; set; }

    [Column("race_id")]
    public int? RaceId { get; set; }

    [Column("is_cpf_entitled")]
    public byte? IsCpfEntitled { get; set; }

    [Column("emp_highest_qual_remarks")]
    [StringLength(500)]
    public string? EmpHighestQualRemarks { get; set; }

    [Column("office_phone_no")]
    [StringLength(50)]
    public string? OfficePhoneNo { get; set; }

    [Column("office_email_id")]
    [StringLength(50)]
    public string? OfficeEmailId { get; set; }

    [Column("pan_card_no")]
    [StringLength(20)]
    public string? PanCardNo { get; set; }

    [Column("aadhar_no")]
    [StringLength(20)]
    public string? AadharNo { get; set; }

    [Column("languages_known")]
    [StringLength(500)]
    public string? LanguagesKnown { get; set; }

    [Column("empt_detail_ref_no")]
    public long? EmptDetailRefNo { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("joining_date", TypeName = "datetime")]
    public DateTime? JoiningDate { get; set; }

    [Column("confirmation_date", TypeName = "datetime")]
    public DateTime? ConfirmationDate { get; set; }

    [Column("probation_period")]
    public int? ProbationPeriod { get; set; }

    [Column("termination_date", TypeName = "datetime")]
    public DateTime? TerminationDate { get; set; }

    [Column("temination_reason")]
    [StringLength(240)]
    public string? TeminationReason { get; set; }

    [Column("empt_type")]
    public int? EmptType { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("resignation_date", TypeName = "datetime")]
    public DateTime? ResignationDate { get; set; }

    [Column("resignation_reason")]
    [StringLength(500)]
    public string? ResignationReason { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("notice_period")]
    public int? NoticePeriod { get; set; }

    [Column("notice_period_in")]
    [StringLength(4)]
    public string? NoticePeriodIn { get; set; }

    [Column("work_day_type")]
    public int? WorkDayType { get; set; }

    [Column("weekly_work_days")]
    public int? WeeklyWorkDays { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("approver_id")]
    public long? ApproverId { get; set; }

    [Column("resignation_type")]
    public short? ResignationType { get; set; }

    [Column("night_shift")]
    public short? NightShift { get; set; }

    [Column("shift_id")]
    public byte? ShiftId { get; set; }

    [Column("exp_type")]
    public short? ExpType { get; set; }

    [Column("total_experience")]
    [StringLength(4)]
    public string? TotalExperience { get; set; }

    [Column("total_experience_in")]
    [StringLength(10)]
    public string? TotalExperienceIn { get; set; }
}
