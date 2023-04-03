using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("LANGAUGE_CODE_REF")]
public partial class LangaugeCodeRef
{
    [Key]
    [Column("language_code")]
    public short LanguageCode { get; set; }

    [Column("is_default")]
    public byte? IsDefault { get; set; }

    [Column("is_internal")]
    public byte? IsInternal { get; set; }

    [Column("created_by")]
    public short? CreatedBy { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("updated_by")]
    public short? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }
}
