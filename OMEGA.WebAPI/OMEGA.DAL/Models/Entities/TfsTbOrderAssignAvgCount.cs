using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ORDER_ASSIGN_AVG_COUNT")]
public partial class TfsTbOrderAssignAvgCount
{
    [Column("assign_count")]
    public int? AssignCount { get; set; }

    [Column("insp_count")]
    public int? InspCount { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
