using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYEE_FAMILY_DETAILS")]
public partial class HrTbEmployeeFamilyDetail
{
    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Key]
    [Column("emp_rel_ref_no")]
    public short EmpRelRefNo { get; set; }

    [Column("rel_name")]
    [StringLength(15)]
    public string? RelName { get; set; }

    [Column("rel_with_emp")]
    public int? RelWithEmp { get; set; }

    [Column("rel_sex")]
    public short? RelSex { get; set; }

    [Column("rel_date_of_birth", TypeName = "datetime")]
    public DateTime? RelDateOfBirth { get; set; }

    [Column("rel_phone_no")]
    [StringLength(50)]
    public string? RelPhoneNo { get; set; }

    [Column("rel_emp_id")]
    public long? RelEmpId { get; set; }

    [Column("rel_status")]
    public int? RelStatus { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("is_verified")]
    public byte? IsVerified { get; set; }

    [Column("verified_by")]
    public int? VerifiedBy { get; set; }

    [Column("verified_remarks")]
    [StringLength(240)]
    public string? VerifiedRemarks { get; set; }

    [Column("famdoc_type")]
    public byte? FamdocType { get; set; }
}
