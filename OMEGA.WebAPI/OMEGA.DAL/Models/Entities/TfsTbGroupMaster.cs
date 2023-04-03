using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_GROUP_MASTER")]
public partial class TfsTbGroupMaster
{
    [Column("group_id")]
    public int? GroupId { get; set; }

    [Column("group_name")]
    public string? GroupName { get; set; }

    [Column("is_mls_grp")]
    public short? IsMlsGrp { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("is_enable")]
    public short? IsEnable { get; set; }
}
