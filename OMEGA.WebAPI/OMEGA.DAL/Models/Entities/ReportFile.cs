using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("Report_Files")]
public partial class ReportFile
{
    [Key]
    public int Sno { get; set; }

    [Column("Report_Id")]
    public int? ReportId { get; set; }

    [Unicode(false)]
    public string? Path { get; set; }

    [Column("Report_File")]
    [Unicode(false)]
    public string? ReportFile1 { get; set; }
}
