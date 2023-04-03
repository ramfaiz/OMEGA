using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class SlVwClientMailInfo1
{
    [Column("CM_CUSTOMER_ID")]
    public int CmCustomerId { get; set; }

    [Column("CM_CUSTOMER_FULL_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CmCustomerFullName { get; set; }

    [Column("CM_EMAIL")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CmEmail { get; set; }

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
