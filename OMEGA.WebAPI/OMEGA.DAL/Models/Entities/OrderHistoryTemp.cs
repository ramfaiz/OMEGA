using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("ORDER_HISTORY_TEMP")]
public partial class OrderHistoryTemp
{
    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("client")]
    public string? Client { get; set; }

    [Column("sub_address")]
    public string? SubAddress { get; set; }

    [Column("portal")]
    public string? Portal { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    public string? Research { get; set; }

    public string? DataEntry { get; set; }

    public string? Submission { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("sub_clientid")]
    public long? SubClientid { get; set; }

    [Column("sub_clientname")]
    public string? SubClientname { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }
}
