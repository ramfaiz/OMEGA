using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ASSIGNED_COUNT_CLIENTS")]
public partial class TfsTbAssignedCountClient
{
    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("Client_Count")]
    [StringLength(100)]
    public string? ClientCount { get; set; }
}
