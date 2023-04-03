using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ORDER_NOTIFICATION")]
public partial class TfsTbOrderNotification
{
    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("added_date", TypeName = "datetime")]
    public DateTime? AddedDate { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("subclient")]
    public string? Subclient { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("due_date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }
}
