using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_STATE_WISE_COUNT")]
public partial class TfsTbStateWiseCount
{
    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("state_name")]
    [StringLength(20)]
    public string? StateName { get; set; }

    [Column("Order_count")]
    public int? OrderCount { get; set; }

    [StringLength(20)]
    public string? Color { get; set; }

    [Column("State_abb")]
    [StringLength(5)]
    public string? StateAbb { get; set; }
}
