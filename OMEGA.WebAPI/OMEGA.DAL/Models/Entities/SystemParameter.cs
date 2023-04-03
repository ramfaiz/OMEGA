using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("Module", "ParameterName")]
[Table("SYSTEM_PARAMETERS")]
public partial class SystemParameter
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string Module { get; set; } = null!;

    [Key]
    [Column("Parameter_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string ParameterName { get; set; } = null!;

    [Column("Int_Value")]
    public int? IntValue { get; set; }

    [Column("Char_value")]
    [StringLength(250)]
    [Unicode(false)]
    public string? CharValue { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Remarks { get; set; }
}
