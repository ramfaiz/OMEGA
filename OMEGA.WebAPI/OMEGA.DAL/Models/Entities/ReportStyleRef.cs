using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("REPORT_STYLE_REF")]
public partial class ReportStyleRef
{
    [Key]
    public short StyleId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StyleName { get; set; }

    [InverseProperty("Style")]
    public virtual ICollection<ReportStyleValue> ReportStyleValues { get; } = new List<ReportStyleValue>();
}
