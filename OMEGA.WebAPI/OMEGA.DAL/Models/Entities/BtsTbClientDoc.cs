using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CLIENT_DOCS")]
public partial class BtsTbClientDoc
{
    [Column("AttachmentID")]
    public long AttachmentId { get; set; }

    [Column("ref_no")]
    public long? RefNo { get; set; }

    public string? FileName { get; set; }

    public string? DisplayName { get; set; }

    [StringLength(100)]
    public string? Path { get; set; }

    public long? Type { get; set; }

    [Column("Upload_on")]
    [StringLength(10)]
    public string? UploadOn { get; set; }

    [Column("delete_status")]
    public long? DeleteStatus { get; set; }

    [Column("Upload_status")]
    public long? UploadStatus { get; set; }

    public long? FileId { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("deleted_by")]
    public long? DeletedBy { get; set; }

    [Column("deleted_date", TypeName = "datetime")]
    public DateTime? DeletedDate { get; set; }
}
