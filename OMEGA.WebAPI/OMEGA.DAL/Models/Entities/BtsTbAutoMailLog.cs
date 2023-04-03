using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_AUTO_MAIL_LOG")]
public partial class BtsTbAutoMailLog
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("pht_email_id")]
    [StringLength(500)]
    public string? PhtEmailId { get; set; }

    [Column("cl_email_id")]
    [StringLength(500)]
    public string? ClEmailId { get; set; }

    [Column("sub")]
    public string? Sub { get; set; }
}
