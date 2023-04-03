using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class RptVwEmpOrganisationDetail
{
    [Column("emp_ref_no")]
    public int? EmpRefNo { get; set; }

    [Column("organisation")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Organisation { get; set; }

    [Column("company")]
    [StringLength(240)]
    [Unicode(false)]
    public string? Company { get; set; }

    [Column("department")]
    [StringLength(240)]
    public string? Department { get; set; }

    [Column("designation")]
    [StringLength(240)]
    public string? Designation { get; set; }

    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("assignment_desc")]
    [StringLength(500)]
    public string? AssignmentDesc { get; set; }

    [Column("empt_detail_ref_no")]
    public long EmptDetailRefNo { get; set; }
}
