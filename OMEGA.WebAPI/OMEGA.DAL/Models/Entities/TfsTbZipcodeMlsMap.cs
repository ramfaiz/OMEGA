using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_ZIPCODE_MLS_MAP")]
public partial class TfsTbZipcodeMlsMap
{
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("zipcode")]
    public long? Zipcode { get; set; }

    [Column("mlsId")]
    public int? MlsId { get; set; }

    [Column("group_id")]
    public int? GroupId { get; set; }
}
