using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwClientMailInfo
{
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("email_id")]
    [StringLength(500)]
    public string? EmailId { get; set; }

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
