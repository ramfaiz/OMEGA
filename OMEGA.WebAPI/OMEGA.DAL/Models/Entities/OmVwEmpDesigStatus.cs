using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class OmVwEmpDesigStatus
{
    [Column("emp_ref_no")]
    public long EmpRefNo { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [Column("status_id")]
    public short StatusId { get; set; }

    [Column("status_reason_id")]
    public short? StatusReasonId { get; set; }
}
