using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("CLIENT_GROUP_MASTER")]
public partial class ClientGroupMaster
{
    [Key]
    [Column("client_group_id")]
    public long ClientGroupId { get; set; }

    [Column("client_group_no")]
    [StringLength(50)]
    public string? ClientGroupNo { get; set; }

    [Column("client_group_desc")]
    [StringLength(500)]
    public string? ClientGroupDesc { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
