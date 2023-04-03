using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("MAIL_LOG_DATA")]
public partial class MailLogDatum
{
    [Key]
    [Column("mail_id")]
    public long MailId { get; set; }

    [Column("mail_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string MailCode { get; set; } = null!;

    [Column("mail_type", TypeName = "numeric(18, 0)")]
    public decimal? MailType { get; set; }

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

    [Column("loginuser")]
    [StringLength(50)]
    public string? Loginuser { get; set; }

    [Column("ipaddress")]
    [StringLength(50)]
    public string? Ipaddress { get; set; }

    [Column("mail_sendornot")]
    public bool? MailSendornot { get; set; }

    [Column("mail_attachment")]
    public bool? MailAttachment { get; set; }

    [Column("UF01")]
    public string? Uf01 { get; set; }

    [Column("UF02")]
    public string? Uf02 { get; set; }

    [Column("UF03")]
    public string? Uf03 { get; set; }
}
