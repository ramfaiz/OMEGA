using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_UNASSIGNED_ORDERS")]
public partial class TfsTbUnassignedOrder
{
    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column("mls_id")]
    public int? MlsId { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("isFresh")]
    public short? IsFresh { get; set; }

    [Column("ord_priority")]
    public short? OrdPriority { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }
}
