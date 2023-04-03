using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_DAILY_ATS_COUNT")]
public partial class TfsTbDailyAtsCount
{
    [Column("client_name")]
    [StringLength(100)]
    public string? ClientName { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("portal")]
    [StringLength(100)]
    public string? Portal { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }
}
