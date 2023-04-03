using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYMENT_HISTORY")]
public partial class HrTbEmploymentHistory
{
    [Key]
    [Column("empt_hist_id")]
    public long EmptHistId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("history_date", TypeName = "date")]
    public DateTime? HistoryDate { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }
}
