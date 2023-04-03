using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_STATE_MASTER")]
public partial class BtsTbStateMaster
{
    [Key]
    [Column("state_id")]
    public long StateId { get; set; }

    [Column("state_name")]
    [StringLength(500)]
    public string? StateName { get; set; }

    [Column("state_abb")]
    [StringLength(500)]
    public string? StateAbb { get; set; }

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
