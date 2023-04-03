using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("MONTH_CLOSING")]
public partial class MonthClosing
{
    [Column("ad_fin_finyrid")]
    public short? AdFinFinyrid { get; set; }

    [Key]
    [Column("period_id")]
    public short PeriodId { get; set; }

    [Column("period_code")]
    [StringLength(60)]
    public string? PeriodCode { get; set; }

    [Column("start_of_period", TypeName = "date")]
    public DateTime? StartOfPeriod { get; set; }

    [Column("end_of_period", TypeName = "date")]
    public DateTime? EndOfPeriod { get; set; }

    [Column("period_status")]
    public byte? PeriodStatus { get; set; }

    [Column("last_updated_by")]
    public short? LastUpdatedBy { get; set; }

    [Column("last_updated_date", TypeName = "datetime")]
    public DateTime? LastUpdatedDate { get; set; }
}
