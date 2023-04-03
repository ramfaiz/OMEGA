using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_ANNOUNCEMENT_SPECIFIC")]
public partial class HrTbAnnouncementSpecific
{
    [Key]
    [Column("entry_dref_no")]
    public long EntryDrefNo { get; set; }

    [Column("entry_ref_no")]
    public long? EntryRefNo { get; set; }

    [Column("org_ref_no")]
    public long? OrgRefNo { get; set; }

    [Column("comp_ref_no")]
    public long? CompRefNo { get; set; }

    [Column("dept_ref_no")]
    public long? DeptRefNo { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }
}
