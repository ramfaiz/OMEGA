using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwMlsZipGroupMap
{
    [Column("zipcode")]
    public long? Zipcode { get; set; }

    [Column("mlsId")]
    public int? MlsId { get; set; }

    [Column("mls_name")]
    public string? MlsName { get; set; }

    [Column("group_name")]
    public string? GroupName { get; set; }

    [Column("is_mls_grp")]
    public short? IsMlsGrp { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }
}
