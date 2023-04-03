using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("MODULES_REF")]
public partial class ModulesRef
{
    [Key]
    [Column("module_id")]
    public int ModuleId { get; set; }

    [Column("menu_id")]
    public int? MenuId { get; set; }

    [Column("is_active")]
    public int? IsActive { get; set; }

    [Column("active_date", TypeName = "date")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "date")]
    public DateTime? InactiveDate { get; set; }

    [Column("module_image")]
    [StringLength(70)]
    [Unicode(false)]
    public string? ModuleImage { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<ModuleValue> ModuleValues { get; } = new List<ModuleValue>();
}
