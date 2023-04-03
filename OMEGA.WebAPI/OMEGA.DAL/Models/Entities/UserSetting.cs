using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[PrimaryKey("UserId", "LoginFinyearid", "FinFinyear")]
[Table("USER_SETTING")]
public partial class UserSetting
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Key]
    [Column("login_finyearid")]
    public int LoginFinyearid { get; set; }

    [Key]
    [Column("fin_finyear")]
    [StringLength(20)]
    public string FinFinyear { get; set; } = null!;
}
