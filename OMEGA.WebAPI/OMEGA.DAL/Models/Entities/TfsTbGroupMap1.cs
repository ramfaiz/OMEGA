using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_GROUP_MAP_1")]
public partial class TfsTbGroupMap1
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("grp_id")]
    public int? GrpId { get; set; }

    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("priority")]
    public int? Priority { get; set; }
}
