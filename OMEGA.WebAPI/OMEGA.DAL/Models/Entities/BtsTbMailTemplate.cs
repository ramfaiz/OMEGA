using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_MAIL_TEMPLATE")]
public partial class BtsTbMailTemplate
{
    [Key]
    [Column("mail_temp_no")]
    public long MailTempNo { get; set; }

    [Column("mail_type")]
    public byte? MailType { get; set; }

    [Column("mail_body")]
    public string? MailBody { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
