using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_EMPLOYEE_JOINING_DATE")]
public partial class TfsTbEmployeeJoiningDate
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("emp_ref_code")]
    public string? EmpRefCode { get; set; }

    [Column("emp_joining_date", TypeName = "datetime")]
    public DateTime? EmpJoiningDate { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }
}
