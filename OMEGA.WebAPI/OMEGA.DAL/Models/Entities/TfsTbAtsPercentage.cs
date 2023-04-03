using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ATS_PERCENTAGE")]
public partial class TfsTbAtsPercentage
{
    [Column("ats_count")]
    public int? AtsCount { get; set; }

    [Column("manual_count")]
    public int? ManualCount { get; set; }

    [Column("percentage")]
    public double? Percentage { get; set; }
}
