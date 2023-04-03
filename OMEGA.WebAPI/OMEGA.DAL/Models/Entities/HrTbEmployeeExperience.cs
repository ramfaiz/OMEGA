using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYEE_EXPERIENCE")]
public partial class HrTbEmployeeExperience
{
    [Key]
    [Column("emp_exp_det_id")]
    public long EmpExpDetId { get; set; }

    [Column("emp_exp_id")]
    public long? EmpExpId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("company_name")]
    [StringLength(50)]
    public string? CompanyName { get; set; }

    [Column("location")]
    [StringLength(50)]
    public string? Location { get; set; }

    [Column("designation")]
    [StringLength(50)]
    public string? Designation { get; set; }

    [Column("experience")]
    [StringLength(50)]
    public string? Experience { get; set; }

    [Column("experience_in")]
    [StringLength(100)]
    public string? ExperienceIn { get; set; }

    [Column("reference")]
    [StringLength(50)]
    public string? Reference { get; set; }

    [Column("phone_number")]
    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [ForeignKey("EmpExpId")]
    [InverseProperty("HrTbEmployeeExperiences")]
    public virtual HrTbEmpExperience? EmpExp { get; set; }
}
