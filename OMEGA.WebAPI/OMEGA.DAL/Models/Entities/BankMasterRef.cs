using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BANK_MASTER_REF")]
public partial class BankMasterRef
{
    [Key]
    [Column("bank_id")]
    public short BankId { get; set; }

    [Column("bank_code")]
    [StringLength(15)]
    [Unicode(false)]
    public string BankCode { get; set; } = null!;

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("updated_by")]
    public short? UpdatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("created_by")]
    public short? CreatedBy { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [InverseProperty("Bank")]
    public virtual ICollection<BankMasterValue> BankMasterValues { get; } = new List<BankMasterValue>();
}
