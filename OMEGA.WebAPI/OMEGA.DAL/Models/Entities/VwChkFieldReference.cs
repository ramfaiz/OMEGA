using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class VwChkFieldReference
{
    [Column("FK_Table")]
    [StringLength(128)]
    public string? FkTable { get; set; }

    [Column("FK_Column")]
    [StringLength(128)]
    public string? FkColumn { get; set; }

    [Column("PK_Table")]
    [StringLength(128)]
    public string? PkTable { get; set; }

    [Column("PK_Column")]
    [StringLength(128)]
    public string? PkColumn { get; set; }

    [Column("Constraint_Name")]
    [StringLength(128)]
    public string ConstraintName { get; set; } = null!;
}
