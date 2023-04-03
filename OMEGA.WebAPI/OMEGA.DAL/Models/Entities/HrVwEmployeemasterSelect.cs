using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmployeemasterSelect
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("employee_name")]
    [StringLength(253)]
    public string? EmployeeName { get; set; }

    [Column("emp_title")]
    [StringLength(50)]
    public string? EmpTitle { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Column("middle_name")]
    [StringLength(50)]
    public string? MiddleName { get; set; }

    [Column("last_name")]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Column("employee_type")]
    public short? EmployeeType { get; set; }

    [Column("date_of_birth", TypeName = "datetime")]
    public DateTime? DateOfBirth { get; set; }

    [Column("employee_type_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmployeeTypeName { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("file_name")]
    [StringLength(100)]
    public string? FileName { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("is_cpf_entitled")]
    public byte? IsCpfEntitled { get; set; }

    [Column("cpf_number")]
    [StringLength(100)]
    public string? CpfNumber { get; set; }

    [Column("tax_number")]
    [StringLength(100)]
    public string? TaxNumber { get; set; }

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

    [Column("emp_org_id")]
    public long? EmpOrgId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("probation_period")]
    public int? ProbationPeriod { get; set; }

    [Column("empt_type")]
    public int? EmptType { get; set; }

    [Column("empt_start_date", TypeName = "datetime")]
    public DateTime? EmptStartDate { get; set; }

    [Column("empt_end_date", TypeName = "datetime")]
    public DateTime? EmptEndDate { get; set; }

    [Column("resignation_date", TypeName = "datetime")]
    public DateTime? ResignationDate { get; set; }

    [Column("empt_status")]
    public int? EmptStatus { get; set; }

    [Column("notice_period")]
    public int? NoticePeriod { get; set; }

    [Column("work_day_type")]
    public int? WorkDayType { get; set; }

    [Column("supervisor_id")]
    public long? SupervisorId { get; set; }

    [Column("night_shift")]
    public short? NightShift { get; set; }

    [Column("gender")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [StringLength(240)]
    public string? Department { get; set; }

    [StringLength(240)]
    public string? Designation { get; set; }
}
