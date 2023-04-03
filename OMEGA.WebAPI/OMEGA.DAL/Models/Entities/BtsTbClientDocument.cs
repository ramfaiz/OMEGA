using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_CLIENT_DOCUMENTS")]
public partial class BtsTbClientDocument
{
    [Key]
    [Column("attachment_id")]
    public int AttachmentId { get; set; }

    [Column("ref_no")]
    public long? RefNo { get; set; }

    [Column("file_path")]
    public string? FilePath { get; set; }

    [Column("type")]
    public int? Type { get; set; }

    [Column("uploaded_by")]
    public long? UploadedBy { get; set; }

    [Column("uploded_date", TypeName = "datetime")]
    public DateTime? UplodedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
