using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwUnassignedOrder
{
    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column("order_id")]
    public int? OrderId { get; set; }

    [Column("mls_id")]
    public int? MlsId { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }

    [Column("isFresh")]
    public short? IsFresh { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }

    [Column("master_account_no")]
    public long? MasterAccountNo { get; set; }

    [Column("hierarchy_id")]
    public long? HierarchyId { get; set; }
}
