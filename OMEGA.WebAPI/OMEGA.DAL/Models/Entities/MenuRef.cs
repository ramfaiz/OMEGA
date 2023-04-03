using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("MENU_REF")]
public partial class MenuRef
{
    [Key]
    [Column("menu_id")]
    public int MenuId { get; set; }

    [Column("is_active")]
    public short? IsActive { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<MenuValue> MenuValues { get; } = new List<MenuValue>();
}
