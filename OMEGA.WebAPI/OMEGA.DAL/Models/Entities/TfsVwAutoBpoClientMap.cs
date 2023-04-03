using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class TfsVwAutoBpoClientMap
{
    [Column("state_name")]
    [StringLength(500)]
    public string? StateName { get; set; }

    [Column("state_abb")]
    [StringLength(500)]
    public string? StateAbb { get; set; }

    [Column("full_name")]
    [StringLength(100)]
    public string? FullName { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("state_id")]
    public int? StateId { get; set; }

    [Column("delete_status")]
    public short? DeleteStatus { get; set; }

    [Column("sl_no")]
    public int SlNo { get; set; }
}
