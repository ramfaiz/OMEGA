using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("SERVER_CATEGORY_REF")]
public partial class ServerCategoryRef
{
    [Column("is_default")]
    public byte IsDefault { get; set; }

    [Key]
    [Column("server_category")]
    public byte ServerCategory { get; set; }
}
