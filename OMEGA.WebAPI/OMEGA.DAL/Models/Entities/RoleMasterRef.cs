using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("ROLE_MASTER_REF")]
public partial class RoleMasterRef
{
    [Key]
    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("role_code")]
    public int? RoleCode { get; set; }

    [Column("is_approval_role")]
    public int? IsApprovalRole { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<RoleMasterValue> RoleMasterValues { get; } = new List<RoleMasterValue>();
}
