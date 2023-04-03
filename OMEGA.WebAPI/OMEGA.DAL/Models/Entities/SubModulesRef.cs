using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SUB_MODULES_REF")]
public partial class SubModulesRef
{
    [Key]
    [Column("sub_module_id")]
    public int SubModuleId { get; set; }

    [Column("module_id")]
    public int ModuleId { get; set; }

    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("sub_module_url")]
    public string? SubModuleUrl { get; set; }

    [Column("is_approval_req")]
    public int? IsApprovalReq { get; set; }

    [Column("is_active")]
    public int? IsActive { get; set; }

    [Column("active_date", TypeName = "date")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "date")]
    public DateTime? InactiveDate { get; set; }

    [InverseProperty("SubModule")]
    public virtual ICollection<SubModuleValue> SubModuleValues { get; } = new List<SubModuleValue>();
}
