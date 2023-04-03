using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_AUTO_BPO_ZIPCODES_1")]
public partial class TfsTbAutoBpoZipcodes1
{
    [Key]
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("zip_code")]
    [StringLength(10)]
    public string? ZipCode { get; set; }
}
