using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_EMPLOYEE_WORK_COUNT_CLIENT_WISE")]
public partial class TfsTbEmployeeWorkCountClientWise
{
    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("counts")]
    public int? Counts { get; set; }
}
