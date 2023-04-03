using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CUSTOMER_ORDER_AUTO_LOG")]
public partial class CustomerOrderAutoLog
{
    [Column("tfs_ord_id")]
    public long? TfsOrdId { get; set; }

    [Column("bts_ord_id")]
    public long? BtsOrdId { get; set; }

    [Column("sub_address")]
    [StringLength(150)]
    public string? SubAddress { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("ord_status")]
    public byte? OrdStatus { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }
}
