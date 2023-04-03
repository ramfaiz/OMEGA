using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_CLIENT_EMAIL_CONFIG")]
public partial class SlTbClientEmailConfig
{
    [Key]
    [Column("client_email_cofig_id")]
    public long ClientEmailCofigId { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("from_mail")]
    public string? FromMail { get; set; }

    [Column("username")]
    public string? Username { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("host_name")]
    public string? HostName { get; set; }

    [Column("port_no")]
    public string? PortNo { get; set; }

    [Column("ssl_id")]
    public byte? SslId { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
