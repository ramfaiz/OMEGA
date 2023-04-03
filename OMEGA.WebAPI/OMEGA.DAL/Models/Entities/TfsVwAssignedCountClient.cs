using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwAssignedCountClient
{
    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("Client_Count")]
    public string? ClientCount { get; set; }
}
