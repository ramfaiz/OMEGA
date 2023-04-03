using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_AUTO_BPO_ORDER_HISTORY")]
public partial class TfsTbAutoBpoOrderHistory
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("auto_bpo_status_id")]
    public int? AutoBpoStatusId { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
