using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("TFS_TB_ORDER_INSTRUCTIONS_FILES")]
public partial class TfsTbOrderInstructionsFile
{
    [Key]
    [Column("sl_no")]
    public int SlNo { get; set; }

    [Column("order_id")]
    public long? OrderId { get; set; }

    [Column("file_path")]
    public string? FilePath { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
