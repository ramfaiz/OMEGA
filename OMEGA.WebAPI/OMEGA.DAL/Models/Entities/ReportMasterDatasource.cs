using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("REPORT_MASTER_DATASOURCE")]
public partial class ReportMasterDatasource
{
    [Key]
    public int DataSourceId { get; set; }

    public int? ReportId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? SourceType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SourceName { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("ReportMasterDatasources")]
    public virtual ReportMasterRef? Report { get; set; }
}
