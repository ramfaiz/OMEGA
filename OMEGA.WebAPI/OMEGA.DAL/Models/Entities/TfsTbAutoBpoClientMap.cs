using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_AUTO_BPO_CLIENT_MAP")]
public partial class TfsTbAutoBpoClientMap
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
