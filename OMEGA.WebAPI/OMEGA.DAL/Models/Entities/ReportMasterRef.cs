using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("REPORT_MASTER_REF")]
public partial class ReportMasterRef
{
    [Key]
    public int ReportId { get; set; }

    public short? ReportWidth { get; set; }

    public short? ReportHeight { get; set; }

    public bool? IsPrePrinted { get; set; }

    public string? RptFilePath { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<ReportMasterDatasource> ReportMasterDatasources { get; } = new List<ReportMasterDatasource>();
}
