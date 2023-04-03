using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ZIPCODE_TREND")]
public partial class TfsTbZipcodeTrend
{
    public int? Zipcode { get; set; }

    public int? Counts { get; set; }
}
