using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_MLS_MASTER")]
public partial class TfsTbMlsMaster
{
    [Column("mls_id")]
    public int? MlsId { get; set; }

    [Column("mls_name")]
    public string? MlsName { get; set; }

    [Column("mls_link")]
    public string? MlsLink { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }
}
