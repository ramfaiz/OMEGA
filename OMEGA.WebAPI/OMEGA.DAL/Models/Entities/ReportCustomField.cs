using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("REPORT_CUSTOM_FIELDS")]
public partial class ReportCustomField
{
    [Key]
    [Column("custom_field_id")]
    public long CustomFieldId { get; set; }

    [Column("report_id")]
    public int? ReportId { get; set; }

    [Column("custom_fields")]
    [StringLength(50)]
    public string? CustomFields { get; set; }

    [Column("display_value")]
    [StringLength(50)]
    public string? DisplayValue { get; set; }

    [Column("reference_table")]
    [StringLength(100)]
    public string? ReferenceTable { get; set; }

    [Column("language_code")]
    public int? LanguageCode { get; set; }

    [Column("is_visible")]
    public int? IsVisible { get; set; }

    [Column("is_mandatory")]
    public int? IsMandatory { get; set; }
}
