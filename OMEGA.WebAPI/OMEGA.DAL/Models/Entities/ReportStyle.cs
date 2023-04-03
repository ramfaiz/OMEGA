using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("ReportId", "PropertyTypeId", "PropertyId")]
[Table("REPORT_STYLES")]
public partial class ReportStyle
{
    [Key]
    [Column("Report_Id")]
    public long ReportId { get; set; }

    [Key]
    [Column("Property_Type_Id")]
    public short PropertyTypeId { get; set; }

    [Key]
    [Column("Property_Id")]
    public short PropertyId { get; set; }

    [Column("Property_Value")]
    [Unicode(false)]
    public string? PropertyValue { get; set; }

    [Column("Field_Name")]
    [Unicode(false)]
    public string? FieldName { get; set; }
}
