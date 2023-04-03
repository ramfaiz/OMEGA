using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMP_EXPERIENCE")]
public partial class HrTbEmpExperience
{
    [Key]
    [Column("emp_exp_id")]
    public long EmpExpId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("exp_type")]
    public short? ExpType { get; set; }

    [Column("total_experience")]
    [StringLength(4)]
    public string? TotalExperience { get; set; }

    [Column("total_experience_in")]
    [StringLength(10)]
    public string? TotalExperienceIn { get; set; }

    [InverseProperty("EmpExp")]
    public virtual ICollection<HrTbEmployeeExperience> HrTbEmployeeExperiences { get; } = new List<HrTbEmployeeExperience>();
}
