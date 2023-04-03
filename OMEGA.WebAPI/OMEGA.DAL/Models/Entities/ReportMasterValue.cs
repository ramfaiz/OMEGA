using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("REPORT_MASTER_VALUES")]
public partial class ReportMasterValue
{
    [Key]
    public int Id { get; set; }

    public int? ReportId { get; set; }

    [Column("Langugae_Code")]
    public short? LangugaeCode { get; set; }

    [Column("Display_Value")]
    [StringLength(100)]
    public string? DisplayValue { get; set; }
}
