using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_DAILY_MANUAL_COUNT")]
public partial class TfsTbDailyManualCount
{
    [Column("client_name")]
    [StringLength(100)]
    public string? ClientName { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("portal")]
    [StringLength(100)]
    public string? Portal { get; set; }
}
