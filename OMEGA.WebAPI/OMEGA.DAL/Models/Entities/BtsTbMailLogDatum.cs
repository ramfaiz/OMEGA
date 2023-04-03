using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_MAIL_LOG_DATA")]
public partial class BtsTbMailLogDatum
{
    [Key]
    [Column("mail_id")]
    public long MailId { get; set; }

    [Column("mail_temp_no")]
    public int? MailTempNo { get; set; }

    [Column("mail_from")]
    public string? MailFrom { get; set; }

    [Column("mail_to")]
    public string? MailTo { get; set; }

    [Column("mail_cc")]
    public string? MailCc { get; set; }

    [Column("mail_bcc")]
    public string? MailBcc { get; set; }

    [Column("mail_sub")]
    public string? MailSub { get; set; }

    [Column("mail_body")]
    public string? MailBody { get; set; }

    [Column("mail_send_datetime", TypeName = "datetime")]
    public DateTime? MailSendDatetime { get; set; }

    [Column("mail_send_by")]
    public long? MailSendBy { get; set; }

    [Column("loginuser")]
    public long? Loginuser { get; set; }

    [Column("ipaddress")]
    public string? Ipaddress { get; set; }

    [Column("mail_sendornot")]
    public byte? MailSendornot { get; set; }

    [Column("mail_attachment")]
    public byte? MailAttachment { get; set; }
}
