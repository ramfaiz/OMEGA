using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_BRANCH_WISE_EMPLOYEE_COUNT")]
public partial class TfsTbBranchWiseEmployeeCount
{
    [Column("refNo")]
    public int? RefNo { get; set; }

    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    [Column("ordCount")]
    public int? OrdCount { get; set; }

    public string? EmpRole { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpYears { get; set; }
}
