using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class CmVwEmporderslist
{
    [Column("ID")]
    public int? Id { get; set; }

    [Column("CODE")]
    [StringLength(100)]
    public string? Code { get; set; }

    [Column("NAME")]
    [StringLength(100)]
    public string? Name { get; set; }

    [Column("LOCATION")]
    [StringLength(100)]
    public string? Location { get; set; }

    [Column("TOTORDERS")]
    [StringLength(100)]
    public string? Totorders { get; set; }

    [Column("ASSIGNED")]
    [StringLength(100)]
    public string? Assigned { get; set; }

    [Column("UNASSIGNED")]
    [StringLength(100)]
    public string? Unassigned { get; set; }
}
