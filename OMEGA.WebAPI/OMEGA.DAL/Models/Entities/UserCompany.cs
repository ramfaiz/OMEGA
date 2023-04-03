using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("UserId", "BaseCompanyId")]
[Table("USER_COMPANY")]
public partial class UserCompany
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Key]
    [Column("base_company_id")]
    public long BaseCompanyId { get; set; }

    [Column("allowed_company_id")]
    public long? AllowedCompanyId { get; set; }

    [Column("allowed_owning_cost_id")]
    public int? AllowedOwningCostId { get; set; }
}
