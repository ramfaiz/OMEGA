using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ACCOUNTS_USER_MASTER")]
public partial class TfsTbAccountsUserMaster
{
    [Column("ref_no")]
    public int RefNo { get; set; }

    [Column("username")]
    [StringLength(10)]
    public string? Username { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }
}
