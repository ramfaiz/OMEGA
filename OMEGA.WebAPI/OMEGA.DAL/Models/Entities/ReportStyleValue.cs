using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("REPORT_STYLE_VALUES")]
public partial class ReportStyleValue
{
    [Key]
    public int StyleDetailsId { get; set; }

    public short? StyleId { get; set; }

    public short? StylePropertyId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StyleDescription { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StyleValue { get; set; }

    [ForeignKey("StyleId")]
    [InverseProperty("ReportStyleValues")]
    public virtual ReportStyleRef? Style { get; set; }
}
