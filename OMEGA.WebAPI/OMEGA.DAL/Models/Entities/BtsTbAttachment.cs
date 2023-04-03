using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_ATTACHMENT")]
public partial class BtsTbAttachment
{
    [Key]
    [Column("AttachmentID")]
    public long AttachmentId { get; set; }

    [Column("OrderID")]
    public long? OrderId { get; set; }

    public string? FileName { get; set; }

    public string? DisplayName { get; set; }

    [StringLength(100)]
    public string? Path { get; set; }

    public long? Type { get; set; }

    [Column("maild")]
    public bool? Maild { get; set; }

    [Column("doc", TypeName = "datetime")]
    public DateTime? Doc { get; set; }

    [Column("UserID")]
    public long? UserId { get; set; }

    [Column("SessionID")]
    public long? SessionId { get; set; }
}
