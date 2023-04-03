using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_RPT_EMP_ABSENTEES_TEMP")]
public partial class TfsTbRptEmpAbsenteesTemp
{
    [Key]
    [Column("sl_no")]
    public long SlNo { get; set; }

    [Column("emp_ref_no")]
    public string? EmpRefNo { get; set; }

    [Column("empcode")]
    [StringLength(50)]
    public string? Empcode { get; set; }

    [Column("employeename")]
    public string? Employeename { get; set; }

    [Column("designation")]
    public string? Designation { get; set; }

    [Column("no_of_absentees")]
    public int? NoOfAbsentees { get; set; }

    [Column("designation_id")]
    public long? DesignationId { get; set; }

    [Column("company_id")]
    public long? CompanyId { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }
}
