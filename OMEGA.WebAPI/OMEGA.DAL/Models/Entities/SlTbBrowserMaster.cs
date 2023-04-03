using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SL_TB_BROWSER_MASTER")]
public partial class SlTbBrowserMaster
{
    [Key]
    [Column("browser_id")]
    public long BrowserId { get; set; }

    [Column("browser_code")]
    [StringLength(50)]
    public string? BrowserCode { get; set; }

    [Column("browser_name")]
    public string? BrowserName { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
