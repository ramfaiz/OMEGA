using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("MAIL_TEMPLATE")]
public partial class MailTemplate
{
    [Key]
    [Column("mail_temp_no")]
    public long MailTempNo { get; set; }

    [Column("mail_type", TypeName = "numeric(8, 0)")]
    public decimal MailType { get; set; }

    [Column("mail_body")]
    public string MailBody { get; set; } = null!;

    [Column("user_id", TypeName = "numeric(8, 0)")]
    public decimal UserId { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }
}
