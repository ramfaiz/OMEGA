using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_REPORT_DATA")]
public partial class BtsTbReportDatum
{
    [Key]
    [Column("report_id")]
    public long ReportId { get; set; }

    [Column("report_name")]
    [StringLength(50)]
    public string? ReportName { get; set; }

    [Column("report_path")]
    public string? ReportPath { get; set; }

    [Column("report_dataset")]
    [StringLength(100)]
    public string? ReportDataset { get; set; }

    [Column("report_table")]
    [StringLength(150)]
    public string? ReportTable { get; set; }

    [Column("report_export_name")]
    [StringLength(50)]
    public string? ReportExportName { get; set; }
}
