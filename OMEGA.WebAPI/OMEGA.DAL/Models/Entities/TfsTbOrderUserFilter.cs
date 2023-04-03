using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ORDER_USER_FILTERS")]
public partial class TfsTbOrderUserFilter
{
    [Column("filter_id")]
    public int FilterId { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("filter_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FilterName { get; set; }

    [Column("status_id")]
    public int? StatusId { get; set; }

    [Column("status_reason_id")]
    public int? StatusReasonId { get; set; }

    [Column("pic_status_id")]
    public int? PicStatusId { get; set; }

    [Column("order_type")]
    public int? OrderType { get; set; }

    [Column("portal_id")]
    public int? PortalId { get; set; }

    [Column("auto_bpo_status_id")]
    public int? AutoBpoStatusId { get; set; }

    [Column("search_count")]
    public int? SearchCount { get; set; }

    [Column("last_used_date", TypeName = "date")]
    public DateTime? LastUsedDate { get; set; }

    [Column("delete_status")]
    public int? DeleteStatus { get; set; }
}
