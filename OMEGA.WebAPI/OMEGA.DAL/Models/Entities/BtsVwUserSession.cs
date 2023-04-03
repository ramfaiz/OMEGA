using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwUserSession
{
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("ipaddress")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ipaddress { get; set; }

    [Column("sessionid")]
    public int Sessionid { get; set; }
}
