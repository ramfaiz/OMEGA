using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_FIPS_COUNTY_ID_MASTER")]
public partial class TfsTbFipsCountyIdMaster
{
    [Column("FIPS")]
    public long? Fips { get; set; }

    [Column("County_name")]
    public string? CountyName { get; set; }

    [Column("State_abb")]
    public string? StateAbb { get; set; }
}
