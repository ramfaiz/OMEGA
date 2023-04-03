using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_AUTO_BPO_ZIPCODES")]
public partial class TfsTbAutoBpoZipcode
{
    [Key]
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("zip_code")]
    [StringLength(10)]
    public string? ZipCode { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
