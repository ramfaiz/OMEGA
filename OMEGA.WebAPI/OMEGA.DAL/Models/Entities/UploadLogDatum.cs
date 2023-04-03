using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("UPLOAD_LOG_DATA")]
public partial class UploadLogDatum
{
    [Key]
    [Column("log_id")]
    public long LogId { get; set; }

    [Column("company_id")]
    public byte? CompanyId { get; set; }

    [Column("location_id")]
    public byte? LocationId { get; set; }

    [Column("file_type")]
    [StringLength(50)]
    public string? FileType { get; set; }

    [Column("file_name")]
    [StringLength(250)]
    public string? FileName { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }
}
