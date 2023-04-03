using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_ANNOUNCEMENT_READBY")]
public partial class HrTbAnnouncementReadby
{
    [Key]
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("entry_ref_no")]
    public long? EntryRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("datetime", TypeName = "datetime")]
    public DateTime? Datetime { get; set; }

    [Column("comment")]
    public string? Comment { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
