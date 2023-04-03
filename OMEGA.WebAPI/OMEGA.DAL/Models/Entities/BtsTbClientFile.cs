using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CLIENT_FILES")]
public partial class BtsTbClientFile
{
    public long? FileId { get; set; }

    [StringLength(100)]
    public string? MainTypefile { get; set; }

    [StringLength(100)]
    public string? SubTypefile { get; set; }

    public string? FileName { get; set; }

    public string? DisplayName { get; set; }

    [StringLength(100)]
    public string? Path { get; set; }

    [Column("delete_stataus")]
    public long? DeleteStataus { get; set; }
}
